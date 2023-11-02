class Plan{
    private string name; //Название учебного плана
    private int duration; //Время обучения
    private int yearStart; //Начало учебного года
    private int yearEnd; //Окончание учебного года
    
    public Program Program {get;set;}; //Связь с блоком образовательной программой
    public student; //Связь с блоком студент
}


class Subject{
    private string name; //Название дисциплины
    private string description; //Описание
    private int hours; //Количество академических часов
    private string[] prerequisites; //Пререквизиты, Другие дисциплины, которые необходимо успешно завершить 
    
    public Teacher Teacher {get;set;} //Связь с блоком преподаватель
    public Plan Plan {get;set;}; //Связь с блоком учебный план
}

class Program{
    private string name; // Название образовательной программы
    private string description;//Описание  образовательной программы
    private string levelEducation; //Оценка уровня образовательной программы
    
    public university; //Связь с блоком учебное заведение
    public plan; //Связь с блоком учебный план
}

class Student{
    private string name;
    private string lastname;
    private DateTime birth;
    private string contacts;
}

class University{
    private string name;
    private string address;
    private string address;
}

class Teacher{
    private string name;
    private string lastname;
    private string contacts;
}




