using System;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс содержит информацию о персонах
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

        private Gender _gender;

        public Person Partner;

        /// <summary>
        /// Создается эеземпляр класса <see cref="Person"/>.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <exception cref="ArgumentException">
        /// Имя не должно быть пустым или null
        /// </exception>
        public Person(string name, string surname, int age, Gender gender)
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
            _gender = gender;
        }

        /// <summary>
        /// Функция возвращает информацию о персонах
        /// </summary>
        /// <returns>Возвращает информацию о персонах</returns>
        public string GetInfo()
        {
            return $"Person name: {_name}, surname {_surname}," +
                $" age is {_age}, gender is {_gender}. \n" +
                $"Person Partner {Partner?.GetInfo()}";
        }

        /// <summary>
        /// Функция позволяет добавлять год при праздновании ДР
        /// </summary>
        public void CelebrateHappyBerthday()
        {
            _age++;
        }
        
    }
}