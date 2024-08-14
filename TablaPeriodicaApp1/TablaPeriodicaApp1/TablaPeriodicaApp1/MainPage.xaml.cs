using System;
using System.Collections.Generic;
using TablaPeriodicaApp1.Models;
using TablaPeriodicaApp1.Models;
using Xamarin.Forms;

namespace TablaPeriodicaApp1
{
    public partial class MainPage : ContentPage
    {
        private List<ElementoTablaPeriodica> elementos;
        private Dictionary<string, Tuple<int, int>> posiciones;
        private Dictionary<string, Color> coloresPorCategoria; 
        private double _currentScale = 1;
        private double _startScale = 1;
        private double _xOffset = 0;
        private double _yOffset = 0;
        public MainPage()
        {
            InitializeComponent();
            InicializarElementos();
            InicializarPosiciones();
            InicializarColores(); 
            CrearBotones();
        }

        private void InicializarElementos()
        {
            elementos = new List<ElementoTablaPeriodica>
            {

new ElementoTablaPeriodica { Simbolo = "H", Nombre = "Hidrógeno", NumeroAtomico = 1, MasaAtomica = 1.008, Anecdota = "El hidrógeno es el elemento más abundante en el universo." },
new ElementoTablaPeriodica { Simbolo = "He", Nombre = "Helio", NumeroAtomico = 2, MasaAtomica = 4.0026, Anecdota = "El helio fue descubierto en el sol antes que en la Tierra." },
new ElementoTablaPeriodica { Simbolo = "Li", Nombre = "Litio", NumeroAtomico = 3, MasaAtomica = 6.94, Anecdota = "El litio se usa en baterías recargables para dispositivos electrónicos." },
new ElementoTablaPeriodica { Simbolo = "Be", Nombre = "Berilio", NumeroAtomico = 4, MasaAtomica = 9.0122, Anecdota = "El berilio se utiliza en aleaciones para herramientas que no producen chispas." },
new ElementoTablaPeriodica { Simbolo = "B", Nombre = "Boro", NumeroAtomico = 5, MasaAtomica = 10.81 , Anecdota = "El boro es un componente esencial del vidrio resistente al calor, como el Pyrex." },
new ElementoTablaPeriodica { Simbolo = "C", Nombre = "Carbono", NumeroAtomico = 6, MasaAtomica = 12.011, Anecdota = "El carbono es la base de la vida orgánica y se encuentra en todas las formas de vida en la Tierra. También forma estructuras como el grafito y el diamante." },
new ElementoTablaPeriodica { Simbolo = "N", Nombre = "Nitrógeno", NumeroAtomico = 7, MasaAtomica = 14.007, Anecdota = "El nitrógeno constituye aproximadamente el 78% de la atmósfera terrestre y es crucial para la producción de amoníaco en la industria química." },
new ElementoTablaPeriodica { Simbolo = "O", Nombre = "Oxígeno", NumeroAtomico = 8, MasaAtomica = 15.999, Anecdota = "El oxígeno es esencial para la respiración en la mayoría de los organismos vivos y es el tercer elemento más abundante en el universo." },
new ElementoTablaPeriodica { Simbolo = "F", Nombre = "Flúor", NumeroAtomico = 9, MasaAtomica = 18.998, Anecdota = "El flúor se utiliza en la producción de teflón y en pastas dentales para prevenir caries." },
new ElementoTablaPeriodica { Simbolo = "Ne", Nombre = "Neón", NumeroAtomico = 10, MasaAtomica = 20.180, Anecdota = "El neón se usa en letreros luminosos debido a su capacidad para emitir luz brillante cuando se aplica una corriente eléctrica." },
new ElementoTablaPeriodica { Simbolo = "Na", Nombre = "Sodio", NumeroAtomico = 11, MasaAtomica = 22.990, Anecdota = "El sodio reacciona violentamente con el agua, produciendo hidrógeno y calor, y es esencial para la función nerviosa en el cuerpo humano." },
new ElementoTablaPeriodica { Simbolo = "Mg", Nombre = "Magnesio", NumeroAtomico = 12, MasaAtomica = 24.305, Anecdota = "El magnesio es un componente clave en la clorofila, la molécula responsable de la fotosíntesis en las plantas." },
new ElementoTablaPeriodica { Simbolo = "Al", Nombre = "Aluminio", NumeroAtomico = 13, MasaAtomica = 26.982, Anecdota = "El aluminio es el metal más abundante en la corteza terrestre y es ampliamente utilizado en la industria de la aviación y en envases de bebidas." },
new ElementoTablaPeriodica { Simbolo = "Si", Nombre = "Silicio", NumeroAtomico = 14, MasaAtomica = 28.085, Anecdota = "El silicio es fundamental para la fabricación de microchips y dispositivos electrónicos, siendo la base de la industria de los semiconductores."},
new ElementoTablaPeriodica { Simbolo = "P", Nombre = "Fósforo", NumeroAtomico = 15, MasaAtomica = 30.974, Anecdota ="El fósforo es un componente esencial de los fertilizantes agrícolas y de los compuestos químicos vitales como el ADN y el ATP." },
new ElementoTablaPeriodica { Simbolo = "S", Nombre = "Azufre", NumeroAtomico = 16, MasaAtomica = 32.06, Anecdota ="El azufre se encuentra en la naturaleza en forma de cristales amarillos y es utilizado en la fabricación de ácido sulfúrico, uno de los productos químicos más producidos industrialmente." },
new ElementoTablaPeriodica { Simbolo = "Cl", Nombre = "Cloro", NumeroAtomico = 17, MasaAtomica = 35.45, Anecdota ="El cloro es un potente desinfectante utilizado para purificar el agua potable y en piscinas." },
new ElementoTablaPeriodica { Simbolo = "Ar", Nombre = "Argón", NumeroAtomico = 18, MasaAtomica = 39.948, Anecdota = "El argón es un gas noble utilizado en bombillas incandescentes para evitar que el filamento se oxide."},
new ElementoTablaPeriodica { Simbolo = "K", Nombre = "Potasio", NumeroAtomico = 19, MasaAtomica = 39.098, Anecdota = "El potasio es crucial para la función celular en los organismos vivos y es uno de los tres nutrientes primarios en los fertilizantes."},
new ElementoTablaPeriodica { Simbolo = "Ca", Nombre = "Calcio", NumeroAtomico = 20, MasaAtomica = 40.078, Anecdota = "El calcio es un componente fundamental de los huesos y dientes en los vertebrados."},
new ElementoTablaPeriodica { Simbolo = "Sc", Nombre = "Escandio", NumeroAtomico = 21, MasaAtomica = 44.956, Anecdota = "El escandio es un metal raro utilizado en aleaciones de aluminio para componentes de aviones."},
new ElementoTablaPeriodica { Simbolo = "Ti", Nombre = "Titanio", NumeroAtomico = 22, MasaAtomica = 47.867, Anecdota = "El titanio es conocido por su alta resistencia y bajo peso, y se usa en prótesis médicas y en la industria aeroespacial."},
new ElementoTablaPeriodica { Simbolo = "V", Nombre = "Vanadio", NumeroAtomico = 23, MasaAtomica = 50.942, Anecdota = "El vanadio se utiliza en aleaciones de acero para mejorar su resistencia a la corrosión y a los impactos."},
new ElementoTablaPeriodica { Simbolo = "Cr", Nombre = "Cromo", NumeroAtomico = 24, MasaAtomica = 51.996, Anecdota = "El cromo se emplea para darle un acabado brillante a los metales, conocido como cromado."},
new ElementoTablaPeriodica { Simbolo = "Mn", Nombre = "Manganeso", NumeroAtomico = 25, MasaAtomica = 54.938, Anecdota = "El manganeso es esencial para la producción de acero y en la fabricación de pilas alcalinas."},
new ElementoTablaPeriodica { Simbolo = "Fe", Nombre = "Hierro", NumeroAtomico = 26, MasaAtomica = 55.845, Anecdota = "El hierro es el metal más utilizado en el mundo, fundamental para la producción de acero y en la fabricación de herramientas y maquinaria."},
new ElementoTablaPeriodica { Simbolo = "Co", Nombre = "Cobalto", NumeroAtomico = 27, MasaAtomica = 58.933, Anecdota = "El cobalto se utiliza en la fabricación de imanes y en baterías recargables."},
new ElementoTablaPeriodica { Simbolo = "Ni", Nombre = "Níquel", NumeroAtomico = 28, MasaAtomica = 58.693, Anecdota = "El níquel es resistente a la corrosión y se usa en monedas, joyería y en baterías recargables."},
new ElementoTablaPeriodica { Simbolo = "Cu", Nombre = "Cobre", NumeroAtomico = 29, MasaAtomica = 63.546, Anecdota = "El cobre es un excelente conductor de electricidad y se utiliza ampliamente en cables eléctricos y componentes electrónicos."},
new ElementoTablaPeriodica { Simbolo = "Zn", Nombre = "Zinc", NumeroAtomico = 30, MasaAtomica = 65.38, Anecdota = "El zinc se usa para galvanizar otros metales, protegiéndolos de la corrosión, y es un componente esencial de muchas enzimas en el cuerpo humano."},
new ElementoTablaPeriodica { Simbolo = "Ga", Nombre = "Galio", NumeroAtomico = 31, MasaAtomica = 69.723, Anecdota = "El galio se utiliza en termómetros de alta temperatura y en LEDs."},
new ElementoTablaPeriodica { Simbolo = "Ge", Nombre = "Germanio", NumeroAtomico = 32, MasaAtomica = 72.63, Anecdota = "El germanio es un semiconductor usado en transistores y en fibra óptica."},
new ElementoTablaPeriodica { Simbolo = "As", Nombre = "Arsénico", NumeroAtomico = 33, MasaAtomica = 74.922, Anecdota = "El arsénico, aunque tóxico, tiene aplicaciones en semiconductores y en pesticidas."},
new ElementoTablaPeriodica { Simbolo = "Se", Nombre = "Selenio", NumeroAtomico = 34, MasaAtomica = 78.96, Anecdota =  "El selenio se usa en fotocopiadoras y es un nutriente esencial en pequeñas cantidades."},
new ElementoTablaPeriodica { Simbolo = "Br", Nombre = "Bromo", NumeroAtomico = 35, MasaAtomica = 79.904, Anecdota = "El bromo es utilizado en retardantes de llama y en fotografía."},
new ElementoTablaPeriodica { Simbolo = "Kr", Nombre = "Kriptón", NumeroAtomico = 36, MasaAtomica = 83.798, Anecdota = "El kriptón se utiliza en luces fluorescentes y en fotografía."},
new ElementoTablaPeriodica { Simbolo = "Rb", Nombre = "Rubidio", NumeroAtomico = 37, MasaAtomica = 85.468, Anecdota =  "El rubidio es utilizado en investigaciones científicas y en relojes atómicos."},
new ElementoTablaPeriodica { Simbolo = "Sr", Nombre = "Estroncio", NumeroAtomico = 38, MasaAtomica = 87.62, Anecdota = "El estroncio es conocido por su uso en fuegos artificiales de color rojo."},
new ElementoTablaPeriodica { Simbolo = "Y", Nombre = "Itrio", NumeroAtomico = 39, MasaAtomica = 88.906, Anecdota = "El itrio se utiliza en pantallas LED y en superconductores."},
new ElementoTablaPeriodica { Simbolo = "Zr", Nombre = "Circonio", NumeroAtomico = 40, MasaAtomica = 91.224, Anecdota = "El circonio es resistente a la corrosión y se usa en reactores nucleares."},
new ElementoTablaPeriodica { Simbolo = "Nb", Nombre = "Niobio", NumeroAtomico = 41, MasaAtomica = 92.906, Anecdota = "El niobio se usa en aleaciones de acero para mejorar su resistencia."},
new ElementoTablaPeriodica { Simbolo = "Mo", Nombre = "Molibdeno", NumeroAtomico = 42, MasaAtomica = 95.95, Anecdota = "El molibdeno se utiliza en aleaciones de alta resistencia y en lubricantes."},
new ElementoTablaPeriodica { Simbolo = "Tc", Nombre = "Tecnecio", NumeroAtomico = 43, MasaAtomica = 98, Anecdota = "El tecnecio es utilizado en medicina nuclear para diagnósticos de imágenes."},
new ElementoTablaPeriodica { Simbolo = "Ru", Nombre = "Rutenio", NumeroAtomico = 44, MasaAtomica = 101.07, Anecdota = "El rutenio se utiliza en la fabricación de contactos eléctricos y en catalizadores."},
new ElementoTablaPeriodica { Simbolo = "Rh", Nombre = "Rodio", NumeroAtomico = 45, MasaAtomica = 102.91, Anecdota = "El rodio es usado para hacer espejos y como catalizador en automóviles."},
new ElementoTablaPeriodica { Simbolo = "Pd", Nombre = "Paladio", NumeroAtomico = 46, MasaAtomica = 106.42, Anecdota = "El paladio se utiliza en catalizadores de automóviles y en joyería."},
new ElementoTablaPeriodica { Simbolo = "Ag", Nombre = "Plata", NumeroAtomico = 47, MasaAtomica = 107.87, Anecdota = "La plata es ampliamente utilizada en joyería, monedas y en equipos electrónicos."},
new ElementoTablaPeriodica { Simbolo = "Cd", Nombre = "Cadmio", NumeroAtomico = 48, MasaAtomica = 112.41, Anecdota = "El cadmio es utilizado en baterías recargables y en recubrimientos resistentes a la corrosión."},
new ElementoTablaPeriodica { Simbolo = "In", Nombre = "Indio", NumeroAtomico = 49, MasaAtomica = 114.82, Anecdota = "El indio se utiliza en pantallas táctiles y en aleaciones para bajar el punto de fusión."},
new ElementoTablaPeriodica { Simbolo = "Sn", Nombre = "Estaño", NumeroAtomico = 50, MasaAtomica = 118.71, Anecdota = "El estaño es usado para hacer aleaciones como el bronce y para soldadura."},
new ElementoTablaPeriodica { Simbolo = "Sb", Nombre = "Antimonio", NumeroAtomico = 51, MasaAtomica = 121.76, Anecdota = "El antimonio es utilizado en retardantes de llama y en aleaciones de baterías."},
new ElementoTablaPeriodica { Simbolo = "Te", Nombre = "Telurio", NumeroAtomico = 52, MasaAtomica = 127.60, Anecdota = "El telurio se utiliza en paneles solares y en aleaciones de acero."},
new ElementoTablaPeriodica { Simbolo = "I", Nombre = "Yodo", NumeroAtomico = 53, MasaAtomica = 126.90, Anecdota = "El yodo es un elemento esencial para la salud humana y se utiliza en antisépticos."},
new ElementoTablaPeriodica { Simbolo = "Xe", Nombre = "Xenón", NumeroAtomico = 54, MasaAtomica = 131.29, Anecdota = "El xenón se usa en luces de alta intensidad y en anestesia médica."},
new ElementoTablaPeriodica { Simbolo = "Cs", Nombre = "Cesio", NumeroAtomico = 55, MasaAtomica = 132.91, Anecdota = "El cesio se utiliza en relojes atómicos y en perforación de pozos petrolíferos."},
new ElementoTablaPeriodica { Simbolo = "Ba", Nombre = "Bario", NumeroAtomico = 56, MasaAtomica = 137.33, Anecdota = "El bario se utiliza en radiografías para mejorar la imagen de los intestinos."},
new ElementoTablaPeriodica { Simbolo = "La", Nombre = "Lantano", NumeroAtomico = 57, MasaAtomica = 138.91, Anecdota = "El lantano se usa en lentes de cámaras y en baterías de vehículos híbridos."},
new ElementoTablaPeriodica { Simbolo = "Ce", Nombre = "Cerio", NumeroAtomico = 58, MasaAtomica = 140.12, Anecdota =  "El cerio es usado en encendedores de chispa y en pulido de vidrios."},
new ElementoTablaPeriodica { Simbolo = "Pr", Nombre = "Praseodimio", NumeroAtomico = 59, MasaAtomica = 140.91, Anecdota = "El praseodimio se utiliza en imanes de alta resistencia y en vidrios de soldadura."},
new ElementoTablaPeriodica { Simbolo = "Nd", Nombre = "Neodimio", NumeroAtomico = 60, MasaAtomica = 144.24, Anecdota =  "El neodimio es conocido por su uso en imanes potentes para motores y altavoces."},
new ElementoTablaPeriodica { Simbolo = "Pm", Nombre = "Prometio", NumeroAtomico = 61, MasaAtomica = 145, Anecdota = "El prometio se utiliza en pintura luminiscente y en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Sm", Nombre = "Samario", NumeroAtomico = 62, MasaAtomica = 150.36, Anecdota = "El samario se usa en imanes de samario-cobalto y en reactores nucleares."},
new ElementoTablaPeriodica { Simbolo = "Eu", Nombre = "Europio", NumeroAtomico = 63, MasaAtomica = 151.96, Anecdota = "El europio es utilizado en pantallas de televisión y en iluminación fluorescente."},
new ElementoTablaPeriodica { Simbolo = "Gd", Nombre = "Gadolinio", NumeroAtomico = 64, MasaAtomica = 157.25, Anecdota = "El gadolinio se usa como agente de contraste en resonancias magnéticas y en materiales de control de reactores nucleares."},
new ElementoTablaPeriodica { Simbolo = "Tb", Nombre = "Terbio", NumeroAtomico = 65, MasaAtomica = 158.93, Anecdota = "El terbio se utiliza en dispositivos electrónicos y en iluminación fluorescente."},
new ElementoTablaPeriodica { Simbolo = "Dy", Nombre = "Disprosio", NumeroAtomico = 66, MasaAtomica = 162.50, Anecdota = "El disprosio es utilizado en imanes de alta temperatura y en sistemas de iluminación."},
new ElementoTablaPeriodica { Simbolo = "Ho", Nombre = "Holmio", NumeroAtomico = 67, MasaAtomica = 164.93, Anecdota = "El holmio es utilizado en láseres y en equipos médicos."},
new ElementoTablaPeriodica { Simbolo = "Er", Nombre = "Erbio", NumeroAtomico = 68, MasaAtomica = 167.26, Anecdota = "El erbio se utiliza en amplificadores de fibra óptica y en láseres médicos."},
new ElementoTablaPeriodica { Simbolo = "Tm", Nombre = "Tulio", NumeroAtomico = 69, MasaAtomica = 168.93, Anecdota = "El tulio es utilizado en fuentes de radiación portátil y en láseres."},
new ElementoTablaPeriodica { Simbolo = "Yb", Nombre = "Iterbio", NumeroAtomico = 70, MasaAtomica = 173.05, Anecdota = "El iterbio se usa en relojes atómicos y en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Lu", Nombre = "Lutecio", NumeroAtomico = 71, MasaAtomica = 174.97, Anecdota = "El lutecio es utilizado en investigaciones científicas y en equipos médicos de alta tecnología."},
new ElementoTablaPeriodica { Simbolo = "Hf", Nombre = "Hafnio", NumeroAtomico = 72, MasaAtomica = 178.49, Anecdota = "El hafnio se utiliza en reactores nucleares y en filamentos de lámparas incandescentes."},
new ElementoTablaPeriodica { Simbolo = "Ta", Nombre = "Tantalio", NumeroAtomico = 73, MasaAtomica = 180.95, Anecdota = "El tantalio es usado en capacitores de dispositivos electrónicos y en aleaciones de alta resistencia."},
new ElementoTablaPeriodica { Simbolo = "W", Nombre = "Wolframio", NumeroAtomico = 74, MasaAtomica = 183.84, Anecdota = "El wolframio tiene el punto de fusión más alto de todos los elementos y se usa en filamentos de bombillas y en herramientas de corte."},
new ElementoTablaPeriodica { Simbolo = "Re", Nombre = "Renio", NumeroAtomico = 75, MasaAtomica = 186.21, Anecdota = "El renio se utiliza en aleaciones para motores a reacción y en catalizadores de refinería."},
new ElementoTablaPeriodica { Simbolo = "Os", Nombre = "Osmio", NumeroAtomico = 76, MasaAtomica = 190.23, Anecdota = "El osmio es el elemento más denso y se utiliza en aleaciones para instrumentos de precisión."},
new ElementoTablaPeriodica { Simbolo = "Ir", Nombre = "Iridio", NumeroAtomico = 77, MasaAtomica = 192.22, Anecdota = "El iridio es altamente resistente a la corrosión y se usa en contactos eléctricos y en joyería."},
new ElementoTablaPeriodica { Simbolo = "Pt", Nombre = "Platino", NumeroAtomico = 78, MasaAtomica = 195.08, Anecdota = "El platino es utilizado en joyería, catalizadores de automóviles y en equipos de laboratorio."},
new ElementoTablaPeriodica { Simbolo = "Au", Nombre = "Oro", NumeroAtomico = 79, MasaAtomica = 196.97, Anecdota = "El oro es valorado por su belleza y rareza, utilizado en joyería, electrónica y como reserva de valor."},
new ElementoTablaPeriodica { Simbolo = "Hg", Nombre = "Mercurio", NumeroAtomico = 80, MasaAtomica = 200.59, Anecdota = "El mercurio es el único metal que es líquido a temperatura ambiente y se usa en termómetros y en amalgamas dentales."},
new ElementoTablaPeriodica { Simbolo = "Tl", Nombre = "Talio", NumeroAtomico = 81, MasaAtomica = 204.38, Anecdota = "El talio es tóxico y se utiliza en insecticidas y en dispositivos electrónicos."},
new ElementoTablaPeriodica { Simbolo = "Pb", Nombre = "Plomo", NumeroAtomico = 82, MasaAtomica = 207.2, Anecdota = "El plomo es conocido por su uso en tuberías antiguas y en baterías de automóviles."},
new ElementoTablaPeriodica { Simbolo = "Bi", Nombre = "Bismuto", NumeroAtomico = 83, MasaAtomica = 208.98, Anecdota =  "El bismuto es el metal menos tóxico de su grupo y se utiliza en cosméticos y en medicina."},
new ElementoTablaPeriodica { Simbolo = "Po", Nombre = "Polonio", NumeroAtomico = 84, MasaAtomica = 209, Anecdota = "El polonio es extremadamente radiactivo y se ha utilizado en eliminadores de estática y en investigaciones nucleares."},
new ElementoTablaPeriodica { Simbolo = "At", Nombre = "Astato", NumeroAtomico = 85, MasaAtomica = 210, Anecdota = "El astato es uno de los elementos más raros en la Tierra y se utiliza en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Rn", Nombre = "Radón", NumeroAtomico = 86, MasaAtomica = 222, Anecdota = "El radón es un gas radiactivo que puede acumularse en edificios y es un riesgo para la salud."},
new ElementoTablaPeriodica { Simbolo = "Fr", Nombre = "Francio", NumeroAtomico = 87, MasaAtomica = 223, Anecdota = "El francio es extremadamente raro y altamente radiactivo, utilizado principalmente en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Ra", Nombre = "Radio", NumeroAtomico = 88, MasaAtomica = 226, Anecdota =  "El radio es radiactivo y fue utilizado en tratamientos de cáncer y en pintura luminiscente."},
new ElementoTablaPeriodica { Simbolo = "Ac", Nombre = "Actinio", NumeroAtomico = 89, MasaAtomica = 227, Anecdota = "El actinio se utiliza en fuentes de neutrones y en investigaciones nucleares."},
new ElementoTablaPeriodica { Simbolo = "Th", Nombre = "Torio", NumeroAtomico = 90, MasaAtomica = 232.04, Anecdota = "El torio es utilizado como material de combustible nuclear y en aleaciones resistentes a altas temperaturas."},
new ElementoTablaPeriodica { Simbolo = "Pa", Nombre = "Protactinio", NumeroAtomico = 91, MasaAtomica = 231.04, Anecdota = "El protactinio es raro y radiactivo, utilizado principalmente en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "U", Nombre = "Uranio", NumeroAtomico = 92, MasaAtomica = 238.03, Anecdota = "El uranio es el combustible principal para los reactores nucleares y en armas nucleares."},
new ElementoTablaPeriodica { Simbolo = "Np", Nombre = "Neptunio", NumeroAtomico = 93, MasaAtomica = 237, Anecdota = "El neptunio es un subproducto del proceso de producción de plutonio y es utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Pu", Nombre = "Plutonio", NumeroAtomico = 94, MasaAtomica = 244, Anecdota = "El plutonio es usado en reactores nucleares y en armas nucleares, y es extremadamente radiactivo."},
new ElementoTablaPeriodica { Simbolo = "Am", Nombre = "Americio", NumeroAtomico = 95, MasaAtomica = 243, Anecdota = "El americio se utiliza en detectores de humo y en fuentes de rayos X."},
new ElementoTablaPeriodica { Simbolo = "Cm", Nombre = "Curio", NumeroAtomico = 96, MasaAtomica = 247, Anecdota = "El curio es utilizado en investigaciones científicas y en generadores de energía en sondas espaciales."},
new ElementoTablaPeriodica { Simbolo = "Bk", Nombre = "Berkelio", NumeroAtomico = 97, MasaAtomica = 247, Anecdota = "El berkelio es utilizado principalmente en investigaciones científicas debido a su rareza y radiactividad."},
new ElementoTablaPeriodica { Simbolo = "Cf", Nombre = "Californio", NumeroAtomico = 98, MasaAtomica = 251, Anecdota = "El californio es utilizado en la iniciación de reacciones nucleares y en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Es", Nombre = "Einstenio", NumeroAtomico = 99, MasaAtomica = 252, Anecdota = "El einsteinio se produce en cantidades extremadamente pequeñas y se utiliza en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Fm", Nombre = "Fermio", NumeroAtomico = 100, MasaAtomica = 257, Anecdota = "El fermio es utilizado en investigaciones científicas y se produce en cantidades muy pequeñas."},
new ElementoTablaPeriodica { Simbolo = "Md", Nombre = "Mendelevio", NumeroAtomico = 101, MasaAtomica = 258, Anecdota = "El mendelevio se utiliza en investigaciones científicas y se produce en cantidades minúsculas."},
new ElementoTablaPeriodica { Simbolo = "No", Nombre = "Nobelio", NumeroAtomico = 102, MasaAtomica = 259, Anecdota = "El nobelio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Lr", Nombre = "Lawrencio", NumeroAtomico = 103, MasaAtomica = 262, Anecdota = "El lawrencio es un elemento radiactivo utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Rf", Nombre = "Rutherfordio", NumeroAtomico = 104, MasaAtomica = 267, Anecdota = "El rutherfordio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Db", Nombre = "Dubnio", NumeroAtomico = 105, MasaAtomica = 270, Anecdota = "El dubnio es un elemento sintético que se usa en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Sg", Nombre = "Seaborgio", NumeroAtomico = 106, MasaAtomica = 271, Anecdota = "El seaborgio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Bh", Nombre = "Bohrio", NumeroAtomico = 107, MasaAtomica = 270, Anecdota = "El bohrio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Hs", Nombre = "Hassio", NumeroAtomico = 108, MasaAtomica = 277, Anecdota = "El hassio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Mt", Nombre = "Meitnerio", NumeroAtomico = 109, MasaAtomica = 276, Anecdota = "El meitnerio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Ds", Nombre = "Darmstadtio", NumeroAtomico = 110, MasaAtomica = 281, Anecdota = "El darmstadtio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Rg", Nombre = "Roentgenio", NumeroAtomico = 111, MasaAtomica = 282, Anecdota = "El roentgenio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Cn", Nombre = "Copernicio", NumeroAtomico = 112, MasaAtomica = 285, Anecdota = "El copernicio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Nh", Nombre = "Nihonio", NumeroAtomico = 113, MasaAtomica = 286, Anecdota = "El nihonio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Fl", Nombre = "Flerovio", NumeroAtomico = 114, MasaAtomica = 289, Anecdota = "El flerovio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Mc", Nombre = "Moscovio", NumeroAtomico = 115, MasaAtomica = 290, Anecdota = "El moscovio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Lv", Nombre = "Livermorio", NumeroAtomico = 116, MasaAtomica = 293, Anecdota = "El livermorio es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Ts", Nombre = "Tenesino", NumeroAtomico = 117, MasaAtomica = 294, Anecdota = "El tenesino es un elemento sintético utilizado en investigaciones científicas."},
new ElementoTablaPeriodica { Simbolo = "Og", Nombre = "Oganesón", NumeroAtomico = 118, MasaAtomica = 294, Anecdota = "El oganesón es el elemento más pesado de la tabla periódica y se utiliza en investigaciones científicas."}

            };
        }

        private void InicializarPosiciones()
        {
            posiciones = new Dictionary<string, Tuple<int, int>>
            {

    { "H", new Tuple<int, int>(0, 0) }, { "He", new Tuple<int, int>(0, 17) },
    { "Li", new Tuple<int, int>(1, 0) }, { "Be", new Tuple<int, int>(1, 1) },
    { "B", new Tuple<int, int>(1, 12) }, { "C", new Tuple<int, int>(1, 13) },
    { "N", new Tuple<int, int>(1, 14) }, { "O", new Tuple<int, int>(1, 15) },
    { "F", new Tuple<int, int>(1, 16) }, { "Ne", new Tuple<int, int>(1, 17) },
    { "Na", new Tuple<int, int>(2, 0) }, { "Mg", new Tuple<int, int>(2, 1) },
    { "Al", new Tuple<int, int>(2, 12) }, { "Si", new Tuple<int, int>(2, 13) },
    { "P", new Tuple<int, int>(2, 14) }, { "S", new Tuple<int, int>(2, 15) },
    { "Cl", new Tuple<int, int>(2, 16) }, { "Ar", new Tuple<int, int>(2, 17) },
    { "K", new Tuple<int, int>(3, 0) }, { "Ca", new Tuple<int, int>(3, 1) },
    { "Sc", new Tuple<int, int>(3, 2) }, { "Ti", new Tuple<int, int>(3, 3) },
    { "V", new Tuple<int, int>(3, 4) }, { "Cr", new Tuple<int, int>(3, 5) },
    { "Mn", new Tuple<int, int>(3, 6) }, { "Fe", new Tuple<int, int>(3, 7) },
    { "Co", new Tuple<int, int>(3, 8) }, { "Ni", new Tuple<int, int>(3, 9) },
    { "Cu", new Tuple<int, int>(3, 10) }, { "Zn", new Tuple<int, int>(3, 11) },
    { "Ga", new Tuple<int, int>(3, 12) }, { "Ge", new Tuple<int, int>(3, 13) },
    { "As", new Tuple<int, int>(3, 14) }, { "Se", new Tuple<int, int>(3, 15) },
    { "Br", new Tuple<int, int>(3, 16) }, { "Kr", new Tuple<int, int>(3, 17) },
    { "Rb", new Tuple<int, int>(4, 0) }, { "Sr", new Tuple<int, int>(4, 1) },
    { "Y", new Tuple<int, int>(4, 2) }, { "Zr", new Tuple<int, int>(4, 3) },
    { "Nb", new Tuple<int, int>(4, 4) }, { "Mo", new Tuple<int, int>(4, 5) },
    { "Tc", new Tuple<int, int>(4, 6) }, { "Ru", new Tuple<int, int>(4, 7) },
    { "Rh", new Tuple<int, int>(4, 8) }, { "Pd", new Tuple<int, int>(4, 9) },
    { "Ag", new Tuple<int, int>(4, 10) }, { "Cd", new Tuple<int, int>(4, 11) },
    { "In", new Tuple<int, int>(4, 12) }, { "Sn", new Tuple<int, int>(4, 13) },
    { "Sb", new Tuple<int, int>(4, 14) }, { "Te", new Tuple<int, int>(4, 15) },
    { "I", new Tuple<int, int>(4, 16) }, { "Xe", new Tuple<int, int>(4, 17) },
    { "Cs", new Tuple<int, int>(5, 0) }, { "Ba", new Tuple<int, int>(5, 1) },
    { "La", new Tuple<int, int>(5, 2) }, { "Ce", new Tuple<int, int>(5, 3) },
    { "Pr", new Tuple<int, int>(5, 4) }, { "Nd", new Tuple<int, int>(5, 5) },
    { "Pm", new Tuple<int, int>(5, 6) }, { "Sm", new Tuple<int, int>(5, 7) },
    { "Eu", new Tuple<int, int>(5, 8) }, { "Gd", new Tuple<int, int>(5, 9) },
    { "Tb", new Tuple<int, int>(5, 10) }, { "Dy", new Tuple<int, int>(5, 11) },
    { "Ho", new Tuple<int, int>(5, 12) }, { "Er", new Tuple<int, int>(5, 13) },
    { "Tm", new Tuple<int, int>(5, 14) }, { "Yb", new Tuple<int, int>(5, 15) },
    { "Lu", new Tuple<int, int>(5, 16) }, { "Hf", new Tuple<int, int>(6, 3) },
    { "Ta", new Tuple<int, int>(6, 4) }, { "W", new Tuple<int, int>(6, 5) },
    { "Re", new Tuple<int, int>(6, 6) }, { "Os", new Tuple<int, int>(6, 7) },
    { "Ir", new Tuple<int, int>(6, 8) }, { "Pt", new Tuple<int, int>(6, 9) },
    { "Au", new Tuple<int, int>(6, 10) }, { "Hg", new Tuple<int, int>(6, 11) },
    { "Tl", new Tuple<int, int>(6, 12) }, { "Pb", new Tuple<int, int>(6, 13) },
    { "Bi", new Tuple<int, int>(6, 14) }, { "Po", new Tuple<int, int>(6, 15) },
    { "At", new Tuple<int, int>(6, 16) }, { "Rn", new Tuple<int, int>(6, 17) },
    { "Fr", new Tuple<int, int>(7, 0) }, { "Ra", new Tuple<int, int>(7, 1) },
    { "Ac", new Tuple<int, int>(7, 2) }, { "Th", new Tuple<int, int>(7, 3) },
    { "Pa", new Tuple<int, int>(7, 4) }, { "U", new Tuple<int, int>(7, 5) },
    { "Np", new Tuple<int, int>(7, 6) }, { "Pu", new Tuple<int, int>(7, 7) },
    { "Am", new Tuple<int, int>(7, 8) }, { "Cm", new Tuple<int, int>(7, 9) },
    { "Bk", new Tuple<int, int>(7, 10) }, { "Cf", new Tuple<int, int>(7, 11) },
    { "Es", new Tuple<int, int>(7, 12) }, { "Fm", new Tuple<int, int>(7, 13) },
    { "Md", new Tuple<int, int>(7, 14) }, { "No", new Tuple<int, int>(7, 15) },
    { "Lr", new Tuple<int, int>(7, 16) }, { "Rf", new Tuple<int, int>(8, 3) },
    { "Db", new Tuple<int, int>(8, 4) }, { "Sg", new Tuple<int, int>(8, 5) },
    { "Bh", new Tuple<int, int>(8, 6) }, { "Hs", new Tuple<int, int>(8, 7) },
    { "Mt", new Tuple<int, int>(8, 8) }, { "Ds", new Tuple<int, int>(8, 9) },
    { "Rg", new Tuple<int, int>(8, 10) }, { "Cn", new Tuple<int, int>(8, 11) },
    { "Nh", new Tuple<int, int>(8, 12) }, { "Fl", new Tuple<int, int>(8, 13) },
    { "Mc", new Tuple<int, int>(8, 14) }, { "Lv", new Tuple<int, int>(8, 15) },
    { "Ts", new Tuple<int, int>(8, 16) }, { "Og", new Tuple<int, int>(8, 17) }

            };
        }

        private void InicializarColores()
        {
            coloresPorCategoria = new Dictionary<string, Color>
            {

            { "H", Color.MediumSlateBlue },    // Hidrógeno
            { "He", Color.LightSkyBlue },   // Helio
            { "Li", Color.DarkOrange },   // Litio
            { "Be", Color.Goldenrod },   // Berilio
            { "B", Color.MediumSeaGreen },    // Boro
            { "C", Color.MediumSlateBlue },        // Carbono
            { "N", Color.MediumSlateBlue },         // Nitrógeno
            { "O", Color.MediumSlateBlue },          // Oxígeno
            { "F", Color.HotPink },        // Flúor
            { "Ne", Color.LightSkyBlue },  // Neón
            { "Na", Color.DarkOrange }, // Sodio
            { "Mg", Color.Goldenrod },  // Magnesio
            { "Al", Color.Khaki },      // Aluminio
            { "Si", Color.MediumSeaGreen },        // Silicio
            { "P", Color.MediumSlateBlue },       // Fósforo
            { "S", Color.MediumSlateBlue },       // Azufre
            { "Cl", Color.HotPink },  // Cloro
            { "Ar", Color.LightSkyBlue },     // Argón
            { "K", Color.DarkOrange }, // Potasio
            { "Ca", Color.Goldenrod },       // Calcio
            { "Sc", Color.YellowGreen }, // Escandio
            { "Ti", Color.YellowGreen },  // Titanio
            { "V", Color.YellowGreen }, // Vanadio
            { "Cr", Color.YellowGreen },        // Cromo
            { "Mn", Color.YellowGreen },   // Manganeso
            { "Fe", Color.YellowGreen },      // Hierro
            { "Co", Color.YellowGreen },      // Cobalto
            { "Ni", Color.YellowGreen },       // Níquel
            { "Cu", Color.YellowGreen },     // Cobre
            { "Zn", Color.YellowGreen },         // Cinc
            { "Ga", Color.Khaki },        // Galio
            { "Ge", Color.MediumSeaGreen },      // Germanio
            { "As", Color.MediumSeaGreen },   // Arsénico
            { "Se", Color.MediumSlateBlue },  // Selenio
            { "Br", Color.HotPink },      // Bromo
            { "Kr", Color.LightSkyBlue },         // Kriptón
            { "Rb", Color.DarkOrange }, // Rubidio
            { "Fr", Color.DarkOrange }, // Francio
            { "Sr", Color.Goldenrod },         // Estroncio
            { "Y", Color.YellowGreen },   // Itrio
            { "Zr", Color.YellowGreen },     // Circonio
            { "Nb", Color.YellowGreen },      // Niobio
            { "Mo", Color.YellowGreen }, // Molibdeno
            { "W", Color.YellowGreen }, // Wolframio
            { "Tc", Color.YellowGreen },      // Tecnecio
            { "Ru", Color.YellowGreen },      // Rutenio
            { "Os", Color.YellowGreen }, // Osmio
            { "Rh", Color.YellowGreen },          // Rodio
            { "Pd", Color.YellowGreen }, // Paladio
            { "Ag", Color.YellowGreen },        // Plata
            { "Cd", Color.YellowGreen },         // Cadmio
            { "In", Color.Khaki },          // Indio
            { "Sn", Color.Khaki },        // Estaño
            { "Sb", Color.MediumSeaGreen }, // Antimonio
            { "Te", Color.MediumSeaGreen },        // Telurio
            { "I", Color.HotPink },     // Yodo
            { "Xe", Color.LightSkyBlue },      // Xenón
            { "Cs", Color.DarkOrange },  // Cesio
            { "Ba", Color.Goldenrod },   // Bario
            { "La", Color.YellowGreen }, // Lantano
            { "Ce", Color.YellowGreen },     // Cerio
            { "Pr", Color.YellowGreen }, // Praseodimio
            { "Nd", Color.YellowGreen }, // Neodimio
            { "Pm", Color.YellowGreen },          // Prometio
            { "Sm", Color.YellowGreen },     // Samario
            { "Eu", Color.YellowGreen },  // Europio
            { "Gd", Color.YellowGreen },     // Gadolinio
            { "Tb", Color.YellowGreen },        // Terbio
            { "Dy", Color.YellowGreen }, // Disprosio
            { "Ho", Color.YellowGreen },       // Holmio
            { "Er", Color.YellowGreen }, // Erbio
            { "Tm", Color.YellowGreen }, // Tulio
            { "Yb", Color.YellowGreen },     // Iterbio
            { "Lu", Color.YellowGreen },    // Lutecio
            { "Hf", Color.YellowGreen },     // Hafnio
            { "Ta", Color.YellowGreen },  // Tantalio
            { "Re", Color.YellowGreen },     // Renio
            { "Ir", Color.YellowGreen },          // Iridio
            { "Pt", Color.YellowGreen },          // Platino
            { "Au", Color.YellowGreen },    // Oro
            { "Hg", Color.YellowGreen },        // Mercurio
            { "Tl", Color.Khaki },       // Talio
            { "Pb", Color.Khaki },   // Plomo
            { "Bi", Color.Khaki },    // Bismuto
            { "Po", Color.MediumSeaGreen },        // Polonio
            { "At", Color.HotPink },       // Astato
            { "Rn", Color.LightSkyBlue },       // Radón
            { "Ra", Color.Goldenrod },      // Radio
            { "Ac", Color.DarkSeaGreen },       // Actinio
            { "Th", Color.DarkSeaGreen },  // Torio
            { "Pa", Color.DarkSeaGreen }, // Protactinio
            { "U", Color.DarkSeaGreen }, // Uranio
            { "Np", Color.DarkSeaGreen },   // Neptunio
            { "Pu", Color.DarkSeaGreen }, // Plutonio
            { "Am", Color.DarkSeaGreen }, // Americio
            { "Cm", Color.DarkSeaGreen },       // Curio
            { "Bk", Color.DarkSeaGreen },       // Berkilio
            { "Cf", Color.DarkSeaGreen },      // Californium
            { "Es", Color.DarkSeaGreen },    // Einstenio
            { "Fm", Color.DarkSeaGreen },    // Fermio
            { "Md", Color.DarkSeaGreen }, // Mendelevio
            { "No", Color.DarkSeaGreen },    // Nobelio
            { "Lr", Color.YellowGreen }, // Lawrencio
            { "Rf", Color.YellowGreen },       // Rutherfordio
            { "Db", Color.YellowGreen },      // Dubnio
            { "Sg", Color.YellowGreen },    // Seaborgio
            { "Bh", Color.YellowGreen },        // Bohrio
            { "Hs", Color.YellowGreen },    // Hassio
            { "Mt", Color.YellowGreen },   // Meitnerio
            { "Ds", Color.YellowGreen }, // Darmstadtio
            { "Rg", Color.YellowGreen },    // Roentgenio
            { "Cn", Color.YellowGreen },    // Copernicio
            { "Nh", Color.Khaki },    // Nihonio
            { "Fl", Color.Khaki }, // Flerovio
            { "Mc", Color.Khaki }, // Moscovio
            { "Lv", Color.Khaki },   // Livermorio
            { "Ts", Color.HotPink },       // Tenesino
            { "Og", Color.LightSkyBlue }         // Oganesón
            };
        }

        private void CrearBotones()
        {
            foreach (var elemento in elementos)
            {
                if (posiciones.TryGetValue(elemento.Simbolo, out var pos))
                {
                    var button = new Button
                    {
                        Text = elemento.Simbolo,
                        Style = (Style)Resources["ElementButtonStyle"]
                       

                    };


                    if (coloresPorCategoria.TryGetValue(elemento.Simbolo, out var color))
                    {
                        button.BackgroundColor = color;
                    }
                    else
                    {
                        button.BackgroundColor = Color.Transparent;
                    }

                    button.Clicked += (s, e) =>
                    {
                        DisplayAlert("Elemento", $"Nombre: {elemento.Nombre}\nNúmero Atómico: {elemento.NumeroAtomico}\nMasa Atómica: {elemento.MasaAtomica}", elemento.Anecdota, "OK");
                    };

                    amy.Children.Add(button, pos.Item2, pos.Item1);
                }
            }
        }

        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue.ToLower();

            foreach (var child in amy.Children)
            {
                if (child is Button button)
                {
                    button.IsVisible = string.IsNullOrEmpty(searchText) || button.Text.ToLower().Contains(searchText);
                }
            }
        }
    }
}