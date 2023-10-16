namespace PM021P_1._2
{
    public partial class MainPage : ContentPage
    {
       // int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {
            NombreEmpleado empleado = new NombreEmpleado
            {
                Nombres = nombresEntry.Text,
                Apellidos = apellidosEntry.Text,
                Correo = correoEntry.Text
            };

            if (DateTime.TryParse(fechaNacimientoEntry.Text, out DateTime fechaNacimiento))
            {
                empleado.FechaNacimiento = fechaNacimiento;
            }

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