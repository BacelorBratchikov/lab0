using System;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Person
    {

        public string Name 
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
                
        }

        internal string _name;

        private string _surname;

        private int _age;

        public Person Partner;

        /// <summary>
        /// Создается эеземпляр класса <see cref="Person"/>.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <exception cref="ArgumentException"></exception>
        public Person(string name, string surname, int age)
        {
            if (name == null)
            {
                throw new ArgumentException("Name should not be null!");
            }

            if (name == string.Empty)
            {
                throw new ArgumentException("Name should not be empty!");
            }

            _name = name;
            _surname = surname;
            _age = age;
        }

        public string GetInfo()
        {
            return $"Person name: {_name}, surname {_surname}, age is {_age}. \n" +
                $"Person Partner {Partner?.GetInfo()}";
        }

        public void CelebrateHappyBerthday()
        {
            _age++;
        }
        
    }
}