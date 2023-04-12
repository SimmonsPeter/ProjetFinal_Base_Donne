using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    public class Employes
    {
        private int _numemp;
        private string _nom;
        private string _prenom;
        private string _adresse;
        private string _courriel;
        private string _telephone;

        public int NumEmp
        {
            get { return _numemp; }
            set { _numemp = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set
            {
                if (value.Length >= 6 && value.Length <= 20 && char.IsUpper(value[0]) && value.Substring(1).All(char.IsLower))
                {
                    _nom = value;
                }
                else
                {
                    throw new ArgumentException("Le nom doit commencer par une lettre majuscule et être composé de 6 à 20 lettres alphabétiques.");
                }
            }
        }

        public string Prenom
        {
            get { return _prenom; }
            set
            {
                if (value.Length >= 6 && value.Length <= 20 && char.IsUpper(value[0]) && value.Substring(1).All(char.IsLower))
                {
                    _prenom = value;
                }
                else
                {
                    throw new ArgumentException("Le prénom doit commencer par une lettre majuscule et être composé de 6 à 20 lettres alphabétiques.");
                }
            }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Courriel
        {
            get { return _courriel; }
            set
            {
                if (value.EndsWith(".ca") || value.EndsWith(".com"))
                {
                    _courriel = value;
                }
                else
                {
                    throw new ArgumentException("Le courriel doit être de la forme 'XXXX@XXXX.ca' ou 'XXXX@XXXX.com'.");
                }
            }
        }

        public string Telephone
        {
            get { return _telephone; }
            set
            {
                if (value.Length == 12 && char.IsDigit(value[0]) && char.IsDigit(value[1]) && char.IsDigit(value[2])
                    && value[3] == ' ' && char.IsDigit(value[4]) && char.IsDigit(value[5]) && char.IsDigit(value[6])
                    && value[7] == '-' && char.IsDigit(value[8]) && char.IsDigit(value[9]) && char.IsDigit(value[10])
                    && char.IsDigit(value[11]))
                {
                    _telephone = value;
                }
                else
                {
                    throw new ArgumentException("Le numéro de téléphone doit être de la forme 'CCC CCC-CCCC'.");
                }
            }
        }
    }
}
