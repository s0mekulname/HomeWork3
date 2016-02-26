using System;

namespace Model
{
    public class Numbertron
    {
        private  Random Rng { get; }

        public Numbertron()
        {
            Rng = new Random();
        }

        // 1. NewNumber - событие, которое оповещает о том, что сгенериро
        // Сгенерированное число должно передаваться в параметрах события
        public event EventHandler<NewNumberEventArgs> NewNumber;

        public virtual void OnNewNumber(int newNumber)
        {
            NewNumber?.Invoke(this, new NewNumberEventArgs(newNumber));
        }

        // 2. Generate - method, генерирует одно случайное число, ничего не возвращает. 
        // О новом числе оповещает при помощи события NewNumber
        public void Generate()
        {
            OnNewNumber(Rng.Next(2));
        }
    }
}
