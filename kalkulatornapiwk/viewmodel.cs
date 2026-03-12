
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace kalkulatornapiwk
{
    internal class Rachunek : INotifyPropertyChanged
    {
        private int l_osob, r_osoba;
        private string message, message1;
        private float suma, napiwek, k_osoba;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand ButtonShow { get; }
        public ICommand ButtonClear { get; }
        public Rachunek()
        {
            L_osob = 1;
            ButtonClear = new Command(Button2);
            ButtonShow = new Command(Button1);
        }
        public float Suma
        {
            get => suma;
            set
            {

                if (suma != value)
                {
                    suma = value;
                    OnPropertyChanged(nameof(Suma));
                }
            }
        }
        public string Message
        {
            get => message;
            set
            {

                if (message != value)
                {
                    message = value;
                    OnPropertyChanged(nameof(Message));
                }
            }
        }
        public string Message1
        {
            get => message1;
            set
            {

                if (message1 != value)
                {
                    message1 = value;
                    OnPropertyChanged(nameof(Message1));
                }
            }
        }
        public int R_osoba
        {
            get => r_osoba;
            set
            {

                if (r_osoba != value)
                {
                    r_osoba = value;
                    OnPropertyChanged(nameof(R_osoba));
                }
            }
        }
        public int L_osob
        {
            get => l_osob;
            set
            {
                
                if (l_osob != value)
                {
                    l_osob = value;
                    OnPropertyChanged(nameof(L_osob));
                }
            }

        }
        public float Napiwek
        {
            get => napiwek;
            set
            {
                
                if (napiwek != value)
                {
                    napiwek = value;
                    OnPropertyChanged(nameof(Napiwek));
                }
            }
        }
        public float K_osoba
        {
            get=> k_osoba;
            set
            {
                
                if (k_osoba != value)
                {
                    k_osoba = value;
                    OnPropertyChanged(nameof(K_osoba));
                }
            }
        }
        private void Button1()
        {
            
            if(R_osoba > 0)
            {
                Suma = (R_osoba + (R_osoba * Napiwek / 100)) * L_osob;
                K_osoba = R_osoba + (R_osoba * Napiwek / 100);
                Message = $"{Suma:F2} złotych";
                Message1 = $"{K_osoba:F2} złotych";
            }
            
        }
        private void Button2()
        {
            Suma = default;
            K_osoba = default;
            Message = default;
            Message1 = default;
            R_osoba = default;
            Napiwek = default;
            L_osob = default;
        }
        protected void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
