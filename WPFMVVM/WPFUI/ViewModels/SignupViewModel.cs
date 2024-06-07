using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFUI.ViewModels;

public class SignupViewModel
{
	

	private string _firstName;

	private string _lastName;
    
	private string _email;
    
	private int _SSN;

    private DateTime _dateOfBirth;

    private string _password;
    
	private string _confirmPassword;




	public int SSN
	{
		get { return _SSN; }
		set { _SSN = value; }
	}


	public string FirstName
	{
		get { return _firstName; }
		set { _firstName = value; }
	}

	public string LastName
	{
		get { return _lastName; }
		set { _lastName = value; }
	}

	public DateTime DateOfBirth
	{
		get { return _dateOfBirth; }
		set { _dateOfBirth = value; }
	}

	public string ConfirmPassword
	{
		get { return _confirmPassword; }
		set { _confirmPassword = value; }
	}

	public string Password
	{
		get { return _password; }
		set { _password = value; }
	}

	public string Email
	{
		get { return _email; }
		set { _email = value; }
	}


	public void SignupButton() 
	{
		
	}
}
