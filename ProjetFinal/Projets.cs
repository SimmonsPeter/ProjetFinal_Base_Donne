using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    public class Projets
    {
        private int _numprojet;
        private string _titre;
        private int _nbheureprevues;

        public int NumProjet
        {
            get { return _numprojet; }
            set { _numprojet = value; }
        }

        public string Titre
        {
            get { return _titre; }
            set
            {
                if (value.Length >= 10 && value.Length <= 40 && char.IsUpper(value[0]) && value.Substring(1).All(char.IsLower))
                {
                    _titre = value;
                }
                else
                {
                    throw new ArgumentException("Le titre doit commencer par une lettre majuscule et être composé de 10 à 40 lettres alphabétiques.");
                }
            }
        }

        public int NbHeuresPrevues
        {
            get { return _nbheureprevues; }
            set
            {
                if (value > 0)
                {
                    _nbheureprevues = value;
                }
                else
                {
                    throw new ArgumentException("Le nombre d'heures prévues doit être supérieur à zéro.");
                }
            }
        }
    }
}
