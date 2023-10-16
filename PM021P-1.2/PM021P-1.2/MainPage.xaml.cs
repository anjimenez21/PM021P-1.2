namespace PM021P_1._2
{
    public partial class MainPage : ContentPage
    {
       // int count = 0;

        public MainPage()
        {
            InitializeComponent();

            fechaNacimientoPicker.DateSelected += (sender, e) =>
            {
                DateTime selectedDate = e.NewDate;
                // Puedes hacer algo con la fecha seleccionada, como almacenarla en tu objeto NombreEmpleado.
            };
        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombresEntry.Text) || string.IsNullOrWhiteSpace(apellidosEntry.Text) || string.IsNullOrWhiteSpace(correoEntry.Text))
            {
                DisplayAlert("Error","Por favor, complete todos los campos.", "OK");
                return; // No continuar con el procesamiento si los campos están vacíos.
            }

            if (fechaNacimientoPicker.Date == DateTime.MinValue)
            {
                DisplayAlert("Error", "Por favor, seleccione una fecha de nacimiento válida.", "OK");
                return; // No continuar con el procesamiento si la fecha es inválida.
            }


            NombreEmpleado empleado = new NombreEmpleado
            {
                Nombres = nombresEntry.Text,
                Apellidos = apellidosEntry.Text,
                Correo = correoEntry.Text,
                FechaNacimiento = fechaNacimientoPicker.Date
            };

          

            if (empleado.IsValid())
            {
                // Mostrar los resultados
                DisplayAlert("Empleado Guardado", $"Nombres: {empleado.Nombres}\nApellidos: {empleado.Apellidos}\nFecha de Nacimiento: {empleado.FechaNacimiento}\nCorreo: {empleado.Correo}", "OK");
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese una dirección de correo válida.", "OK");
            }
        }
    }
}