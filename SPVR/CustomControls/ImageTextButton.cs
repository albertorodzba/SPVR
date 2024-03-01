using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPVR.CustomControls
{
    /// <summary>
    ///  Realice los pasos 1a o 1b y luego 2 para usar este control personalizado en un archivo XAML.
    ///
    /// Paso 1a) Usar este control personalizado en un archivo XAML existente en el proyecto actual.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SPVR.CustomControls"
    ///
    ///
    /// Paso 1b) Usar este control personalizado en un archivo XAML existente en otro proyecto.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SPVR.CustomControls;assembly=SPVR.CustomControls"
    ///
    /// Tendrá también que agregar una referencia de proyecto desde el proyecto en el que reside el archivo XAML
    /// hasta este proyecto y recompilar para evitar errores de compilación:
    ///
    ///     Haga clic con el botón secundario del mouse en el proyecto de destino en el Explorador de soluciones y seleccione
    ///     "Agregar referencia"->"Proyectos"->[Busque y seleccione este proyecto]
    ///
    ///
    /// Paso 2)
    /// Prosiga y utilice el control en el archivo XAML.
    ///
    ///     <MyNamespace:ImageTextButton/>
    ///
    /// </summary>
    public class ImageTextButton : Button
    {
        public static readonly DependencyProperty FuenteImagenProperty;
        public static readonly DependencyProperty TextoProperty;
        static ImageTextButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageTextButton), new FrameworkPropertyMetadata(typeof(ImageTextButton)));
            FuenteImagenProperty = DependencyProperty.Register("FuenteImagen", typeof(ImageSource), typeof(ImageTextButton));
            TextoProperty = DependencyProperty.Register("Texto", typeof(String), typeof(ImageTextButton));
        }

        public ImageSource FuenteImagen
        {
            get { return (ImageSource)GetValue(FuenteImagenProperty); }
            set { SetValue(FuenteImagenProperty, value); }
        }

        public String Texto
        {
            get { return (String)GetValue(TextoProperty); }
            set { SetValue(TextoProperty, value); }
        }
    }
}
