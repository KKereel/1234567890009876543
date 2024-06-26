﻿using System;
using MAIN_LIBRARY;
using System.Buffers;
using System.Text.RegularExpressions;

#region ПРОЧТИ
///  ЭТО ВЕЛИКОЛЕПНАЯ БИБЛИОТЕКА КЛАССОВ
///  ВСЕ ЧТО ОТ ВАС НАДО - ЭТО СОЗДАТЬ СВОЙ СОБСТВЕННЫЙ !!КЛАСС!!
///  И НАД НИМ ПОДПИСАТЬ В ЧТО ОН, КТО ОН, КЕМ ОН.
///  ПРИ КОММИТЕ ВЫ УКАЗЫВАЕТЕ ВАРИАНТ
///  ЕСЛИ БИБЛИОТЕК ВДРУГ СТАЛО БОЛЬШЕ ЧЕМ ЭТО
///  ТО ВЫ СНОВА БУБЫЛДА ДУРАЦКАЯ И ВСЕ СЛОМАЛИ
#endregion
namespace MAIN_LIBRARY
{
    /// <summary>
    /// Класс должность
    /// Вариант 10
    /// Малегин Дмитрий
    /// </summary>
    public class Doljnost
    {
        private string _name;
        private double _salary;
        private Podrozdelenie _podrozdelenie;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public double Salary
        {
            set
            {
                if (value >= 0) { _salary = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
            get { return _salary; }
        }
        public Doljnost(string name, double salary, Podrozdelenie podrozdelenie)
        {
            Name = name;
            Salary = salary;
            _podrozdelenie = podrozdelenie;
        }
    }
    /// <summary>
    /// Класс Студент
    /// Вариант 5
    /// Клюев Никита
    /// </summary>
    public class Student
    {
        private Group1 _group1;
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string otchestvo;
        public string OTchestvo
        {
            get { return otchestvo; }
            set { otchestvo = value; }
        }
        private DateTime dateofbirth;
        public DateTime Dateofbirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }
        public Student(string surname, string name, string otchestvo, DateTime dateofbith, Group1 group1)
        {
            Surname = surname;
            Name = name;
            OTchestvo = otchestvo;
            Dateofbirth = dateofbith;
            _group1 = group1;
        }
    }
    /// <summary>
    /// Класс Аудитория
    /// Вариант 2
    /// Дайлиденок Никита
    /// </summary>
    public class Auditoria
    {
        private string _Name;
        private Sotrudnic _sotrudnic = new Sotrudnic();
        private string _Seat = "23";
        private string _Windows = "2";

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Seat
        {
            get { return _Seat; }
            set { _Seat = value; }
        }
        public string Windows
        {
            get { return _Windows; }
            set { _Windows = value; }
        }
        public Auditoria(string name, Sotrudnic sotrudnic, string seat, string windows)
        {
            _Name = name;
            _sotrudnic = sotrudnic;
            _Seat = seat;
            _Windows = windows;
        }
    }
    /// <summary>
    /// Класс Подразделение
    /// Вариант 11
    /// Носков Иван
    /// </summary>
    public class Podrozdelenie
    {
        private string _nazvanie;
        private string _rukovoditel;
        private Organizaciya _organizaciya;
        public string Nazvanie
        {
            get { return _nazvanie; }
            set { _nazvanie = value; }
        }
        public string Rukovoditel
        {
            get { return _rukovoditel; }
            set { _rukovoditel = value; }
        }
        public Organizaciya Organizaciya
        {
            get { return _organizaciya; }
            set { _organizaciya = value; }
        }
        public Podrozdelenie(string nazvanie, string rukovoditel, Organizaciya organizaciya)
        {
            Nazvanie = nazvanie;
            Rukovoditel = rukovoditel;
            Organizaciya = organizaciya;
        }
    }
    /// <summary>
    /// Класс организация
    /// Вариант 12
    /// Рыбаков Кирилл
    /// </summary>
    public class Organizaciya
    {
        private string _nazvanie;
        private string _yuridicheskiyAdres;
        private string _fakticheskiyAdres;
        public Organizaciya(string nazvanie, string yuridicheskiyAdres, string fakticheskiyAdres)
        {
            _nazvanie = nazvanie;
            _yuridicheskiyAdres = yuridicheskiyAdres;
            _fakticheskiyAdres = fakticheskiyAdres;
        }
    }
    /// <summary>
    /// Класс Группа
    /// Вариант 4
    /// Киселёв Александр
    /// </summary>
    public class Group1
    {
        private string _nazvanie;
        private string _sokrachenie;
        private string _chislennost;
        private int _godpostuplenija;
        private Sotrudnic _sotrudnic = new Sotrudnic();
        public string Nazvanie
        {
            get { return _nazvanie; }
            set { _nazvanie = value; }
        }
        public string Sokrachenie
        {
            get { return _sokrachenie; }
            set { _sokrachenie = value; }
        }
        public string Chislennost
        {
            get { return _chislennost; }
            set { _chislennost = value; }
        }
        public int Godpostuplenija
        {
            set
            {
                if (value >= 0) { _godpostuplenija = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
            get { return _godpostuplenija; }
        }
        public Group1(string nazvanie, string sokrachenie, string chislennost, int godpostuplenija, Sotrudnic sotrudnic)
        {
            Nazvanie = nazvanie;
            Sokrachenie = sokrachenie;
            Chislennost = chislennost;
            Godpostuplenija = godpostuplenija;
            _sotrudnic = sotrudnic;
        }
    }
    /// <summary>
    /// Класс дисциплина
    /// Вариант 3
    /// Доронин Александр
    /// </summary>
    public class Discipline
    {
        private string name;
        private string reduction;

        public Discipline(string name, string reduction)
        {
            this.name = name;
            this.reduction = reduction;
        }
    }
    /// <summary>
    /// Класс корпус
    /// Вариант 13
    /// Смирнов Евгений
    /// </summary>
    public class Corpus
    {
        private string Name { get; set; }
        private string Adress { get; set; }
        private string Comm { get; set; }
        private string Org { get; set; }

        public Corpus(string name, string adress)
        {
            Name = name;
            Adress = adress;
            Comm = "-";
            Org = "-";
        }
    }
    /// <summary>
    /// Класс смена
    /// Вариант 8
    /// Крылов Арсений
    /// </summary>
    public class Smena
    {
        public string Name { get; }
        public Smena(string name)
        {
            Name = name;
        }
        public Smena()
        {
        }
    }
    /// <summary>
    /// Класс Вид Занятий
    /// Вариант 14
    /// Смирнов Кирилл
    /// </summary>
    class Vid_Zan
    {
        private string Name;
        public Vid_Zan(string name)
        {
            Name = name;
        }
    }
    /// <summary>
    /// Класс Пара
    /// вариант 7
    /// Костров Егор
    /// </summary>
    public class Para
    {
        private DateTime StartPara;
        private DateTime EndPara;
        private DateTime StartChill;
        private DateTime EndChill;
        private Smena Smena = new Smena();
        public DateTime ParaStart
        {
            get
            {
                return StartPara;
            }
            set
            {
                StartPara = value;
            }
        }
        public DateTime ParaEnd
        {
            get
            {
                return EndPara;
            }
            set
            {
                EndPara = value;
            }
        }
        public DateTime ChillStart
        {
            get
            {
                return StartChill;
            }
            set
            {
                StartChill = value;
            }
        }
        public DateTime ChillEnd
        {
            get
            {
                return EndChill;
            }
            set
            {
                EndChill = value;
            }
        }
        public Para(DateTime startpara, DateTime endpara, DateTime startchill, DateTime endchill, Smena smena)
        {
            StartPara = startpara;
            EndPara = endpara;
            StartChill = startchill;
            EndChill = endchill;
            Smena = smena;
        }
        public Para(DateTime startpara, DateTime endpara, DateTime startchill, DateTime endchill)
        {
            StartPara = startpara;
            EndPara = endpara;
            StartChill = startchill;
            EndChill = endchill;
        }
        public Para()
        {
        }
    }
    /// <summary>
    /// Класс Сотрудник 
    /// Вариант 9
    /// Кулишенко Кирилл 
    /// </summary>
    public class Sotrudnic
    {
        private string _Surname;
        private string _Name;
        private string _Otchestvo;
        private Doljnost doljnost;

        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Otchestvo
        {
            get { return _Otchestvo; }
            set { _Otchestvo = value; }
        }
        public Doljnost _doljnost
        {
            get { return _doljnost; }
            set { _doljnost = value; }
        }
        public Sotrudnic(string surname, string name, string otchestvo, Doljnost doljnost)
        {
            _Surname = name;
            _Name = name;
            _Otchestvo = otchestvo;
            _doljnost = doljnost;
        }
        public Sotrudnic()
        {
        }
    }
}
