using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dantecMarket.Modeles
{
    public class SousCategorie
    {
        #region Attributs
        private int id;
        private string nom;
        #endregion

        #region Constructeurs
        public SousCategorie(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
        #endregion

        #region Getters/Setters
        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }

        [JsonProperty("nom")]
        public string Nom { get => nom; set => nom = value; }
        #endregion

        #region methodes
        
        #endregion
    }
}
