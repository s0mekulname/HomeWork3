namespace Model
{
    public abstract class Gambler
    {
        protected Gambler(string name)
        {
            Name = name;
        }

        // 1. Name - readonly property, задается параметром конструктора
        public string Name { get; }

        // 2. Score - property, setter должен быть закрыт для внешнего кода
        public int Score { get; protected set; }

        // 3. FetchNewNumber – abstract method, по сигнатуре 
        // подходящий для обработки события Numbertron.NewNumber
        public abstract void FetchNewNumber(object sender, NewNumberEventArgs e);
    }
}
