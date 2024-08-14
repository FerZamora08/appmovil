using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TablaPeriodicaApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public QuizPage()
        {
            InitializeComponent();
            LoadQuestions();
            DisplayCurrentQuestion();
        }

        private void LoadQuestions()
        {
            questions = new List<Question>
            {
                new Question { Text = "¿Cuál es el símbolo del elemento con el número atómico 8?", CorrectAnswer = "O", Options = new List<string> { "O", "N", "F", "Ne" } },
                new Question { Text = "¿Qué elemento es conocido como el 'metal de transición más abundante en la corteza terrestre'?", CorrectAnswer = "Aluminio", Options = new List<string> { "Hierro", "Aluminio", "Titanio", "Zinc" } },
                new Question { Text = "¿Qué gas es esencial para la respiración humana?", CorrectAnswer = "Oxígeno", Options = new List<string> { "Oxígeno", "Nitrógeno", "Dióxido de carbono", "Helio" } },
                new Question { Text = "¿Qué elemento tiene el símbolo 'Na'?", CorrectAnswer = "Sodio", Options = new List<string> { "Níquel", "Neón", "Sodio", "Nitrógeno" } },
                new Question { Text = "¿Qué elemento tiene el número atómico 1?", CorrectAnswer = "Hidrógeno", Options = new List<string> { "Helio", "Litio", "Hidrógeno", "Oxígeno" } }
            };
        }

        private void DisplayCurrentQuestion()
        {
            var question = questions[currentQuestionIndex];
            Questionlabel.Text = question.Text;
            Optionslayout.Children.Clear();

            foreach (var option in question.Options)
            {
                var button = new Button
                {
                    Text = option,
                    BackgroundColor = Color.LightGray,
                    TextColor = Color.Black,
                    Margin = new Thickness(0, 5)
                };
                button.Clicked += OnOptionSelected;
                Optionslayout.Children.Add(button);
            }
        }

        private async void OnOptionSelected(object sender, EventArgs e)
        {
            var button = sender as Button;
            var selectedAnswer = button.Text;

            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
            {
                await DisplayAlert("Correcto", "¡Respuesta correcta!", "OK");
                score++;
            }
            else
            {
                await DisplayAlert("Incorrecto", "La respuesta correcta es: " + questions[currentQuestionIndex].CorrectAnswer, "OK");
            }

            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                DisplayCurrentQuestion();
            }
            else
            {
                bool retry = await DisplayAlert("Fin del Quiz", $"Tu puntuación es: {score}/{questions.Count}\n¿Quieres volver a intentarlo?", "Sí", "No");
                if (retry)
                {
                    // Reiniciar el cuestionario
                    currentQuestionIndex = 0;
                    score = 0;
                    DisplayCurrentQuestion();
                }
                else
                {
                    // Regresar al inicio
                    await Navigation.PopToRootAsync();
                }
            }
        }

        private void OnNextQuestion(object sender, EventArgs e)
        {
            if (currentQuestionIndex < questions.Count)
            {
                DisplayCurrentQuestion();
            }
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Options { get; set; }
    }
}