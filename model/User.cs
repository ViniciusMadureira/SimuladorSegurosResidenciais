namespace Classes
{
	public class User
	{
		private string name;
		private long phone;
		private string email;

		protected void setName(string name)
		{
			if (name.Length > 2)
			{
				this.name = name;
			}
		}

		public string getName()
		{
			return name;
		}

		public string obterNome()
		{
			return null;
		}

		private void atribuirTelefone(long telefone)
		{

		}

		public long obterTelefone()
		{
			return 0;
		}

		private void atribuirEmail(string email)
		{

		}

		public string obterEmail()
		{
			return null;
		}

	}

}

