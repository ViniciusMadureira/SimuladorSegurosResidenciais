using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Classes
{
	public class User
	{
		private string name;
		private Int64 phone;
		private string email;
		private string street;
		private Int64 number;
		private string neighborhood;
		private string city;
		private string stateAcronym;

		public User(string name, Int64 phone, string email, string street, Int64 number, string neighborhood, string city, string stateAcronym)
		{
			setName(name);
			setPhone(phone);
			setEmail(email);
			setStreet(street);
			setNumber(number);
			setNeighborhood(neighborhood);
			setCity(city);
			setStateAcronym(stateAcronym);
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

		private void setStreet(string street)
		{
			if (street.Length >= 2 && street.Length <= 30)
			{
				this.street = street;
			}
		}

		public string getStreet()
		{
			return street;
		}

		private void setNumber(Int64 number)
		{
			if (number >= 0 && number <= 9999999)
			{
				this.number = number;
			}
		}

		public Int64 getNumber()
		{
			return number;
		}

		private void setNeighborhood(string neighborhood)
		{
			if (neighborhood.Length >= 2 && neighborhood.Length <= 30)
			{
				this.neighborhood = neighborhood;
			}
		}
		public string getNeighborhood()
		{
			return neighborhood;
		}
		
		private void setCity(string city)
		{
			if (city.Length >= 2 && city.Length <= 30)
			{
				this.city = city;
			}
		}

		public string getCity()
		{
			return city;
		}

		private void setStateAcronym(string stateAcronym)
		{
			if (Regex.IsMatch(stateAcronym, @"^[a-zA-Z]{2}$"))
			{
				this.stateAcronym = stateAcronym;
			}
		}

		public string getStateAcronym()
		{
			return stateAcronym;
		}

	}

}

