using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.Models
{
    public class RegistrationUser
    {
        private string firstName;
        private string lastName;
        private List<bool> matrialStatus;
        private List<bool> hobbies;
        private string country;
        private string birthYear;
        private string birthMonth;
        private string birthDay;
        private string phone;
        private string userName;
        private string email;
        private string picture;
        private string about;
        private string password;
        private string confirmPassword;

        public RegistrationUser
                    (string firstName,
                         string lastName,
                         List<bool> matrialStatus,
                         List<bool> hobbies,
                         string country,
                         string birthYear,
                         string birthMonth,
                         string birthDay,
                         string phone,
                         string userName,
                         string email,
                         string picture,
                         string about,
                         string password,
                         string confirmPassword)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.matrialStatus = matrialStatus;
            this.hobbies = hobbies;
            this.country = country;
            this.birthYear = birthYear;
            this.birthMonth = birthMonth;
            this.birthDay = birthDay;
            this.phone = phone;
            this.userName = userName;
            this.email = email;
            this.picture = picture;
            this.about = about;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

        public String FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public String LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public List<bool> MatrialStatus
        {
            get { return this.matrialStatus; }
            set { this.matrialStatus = value; }
        }
        public List<bool> Hobbies
        {
            get { return this.hobbies; }
            set { this.hobbies = value; }
        }
        public String Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public String BirthYear
        {
            get { return this.birthYear; }
            set { this.birthYear = value; }
        }
        public String BirthMonth
        {
            get { return this.birthMonth; }
            set { this.birthMonth = value; }
        }
        public String BirthDay
        {
            get { return this.birthDay; }
            set { this.birthDay = value; }
        }
        public String Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public String UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public String Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }
        public String About
        {
            get { return this.about; }
            set { this.about = value; }
        }
        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public String ConfirmPassword
        {
            get { return this.confirmPassword; }
            set { this.confirmPassword = value; }
        }

    }
}
