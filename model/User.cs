using System;
using System.Text.RegularExpressions;

namespace Classes
{
	public class User
	{
		private string name;
		private Int64 phone;
		private string email;
		private City city;

		public User(string name, Int64 phone, string email, City city)
		{
			setName(name);
			setPhone(phone);
			setEmail(email);
			setCity(city);
		}

		protected void setName(string name)
		{
			if (name.Length >= 3 && name.Length <= 80)
			{
				this.name = name;
			}
		}

		public string getName()
		{
			return name;
		}

		private void setPhone(Int64 phone)
		{
			string strPhone = phone.ToString();
			if (Regex.IsMatch(strPhone, @"^\d+$") && (strPhone.Length == 10 || strPhone.Length == 11))
			{
				this.phone = phone;
			}
		}

		public Int64 getPhone()
		{
			return phone;
		}

		private void setEmail(string email)
		{
			try
			{
				new System.Net.Mail.MailAddress(email);
				this.email = email;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public string getEmail()
		{
			return email;
		}

		private void setCity(City city)
		{
			if (city != null)
			{
				this.city = city;
			}
		}
		public City getCity()
		{
			return city;
		}

	}

}

