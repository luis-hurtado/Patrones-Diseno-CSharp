using System;

namespace Mediator.Ejercicio
{
    public class DialogBoxRegistro
	{
		private TextBox txtUsuario = new TextBox();
		private TextBox txtContrasena = new TextBox();
		private CheckBox chkAceptaTerminos = new CheckBox();
		private Button btnRegistrarUsuario = new Button();

		public DialogBoxRegistro()
		{
			txtUsuario.AgregarEvento(AlCambiar);
			txtContrasena.AgregarEvento(AlCambiar);
			chkAceptaTerminos.AgregarEvento(AlCambiar);
		}

		private void AlCambiar()
		{
			btnRegistrarUsuario.Habilitado = ValidarFormulario;
		}

		private bool ValidarFormulario
		{
			get
			{
				return !txtUsuario.EsVacio && !txtContrasena.EsVacio && chkAceptaTerminos.Checked;
			}
		}

		public virtual void SimularInteraccionDelUsuario()
		{
			// inicialmente el boton debe estar desactivado
			Console.WriteLine("Inicialmente: " + btnRegistrarUsuario.Habilitado);

			// El usuario coloca su username, El boton todavia esta deshabilitado
			txtUsuario.Texto = "Nombre Usuario";
			Console.WriteLine("Despues de cambiar el nombre de usuario: " + btnRegistrarUsuario.Habilitado);

			// El usuario coloca su contraseña, El boton todavia esta deshabilitado
			txtContrasena.Texto = "Contraseña";
			Console.WriteLine("Despues de cambiar la contraseña: " + btnRegistrarUsuario.Habilitado);

			// El usuario acepta los terminos, el boton se habilita
			chkAceptaTerminos.Checked = true;
			Console.WriteLine("Despues de aceptar los terminos: " + btnRegistrarUsuario.Habilitado);

			// El usuario limpia su contraseña, el boton se deshabilita
			txtContrasena.Texto = "";
			Console.WriteLine("Despues de quitar la contraseña: " + btnRegistrarUsuario.Habilitado);

			// el usuario vuelve a ingresar la contraseña, el boton se habilita
			txtContrasena.Texto = "nueva contraseña";
			Console.WriteLine("despues de colocar la nueva contraseña: " + btnRegistrarUsuario.Habilitado);
		}
	}
}
