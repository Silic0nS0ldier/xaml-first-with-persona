using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlFirstWithPersona
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Persona : ContentView
    {
        public Persona()
        {
            InitializeComponent();
        }

        public string Name
        {
            get
            {
                return (string)this.GetValue(Persona.NameProperty);
            }
            set
            {
                this.SetValue(Persona.NameProperty, value);
            }
        }

        public static readonly BindableProperty NameProperty = BindableProperty.Create(
            propertyName: nameof(Persona.Name),
            returnType: typeof(string),
            declaringType: typeof(Persona));

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == Persona.NameProperty.PropertyName)
            {
                this.NameLabel.Text = this.Name;
            }
        }
    }
}