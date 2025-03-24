using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dantecMarket.Modeles.PostApis
{
    public class AjouterProduitCommande
    {
        #region Attributs
        private int userId;
        private int produitId;
        private int quantite;
        private int prix;
        #endregion

        #region Constructeurs
        public AjouterProduitCommande(int userId, int produitId, int quantite, int prix)
        {
            this.userId = userId;
            this.produitId = produitId;
            this.quantite = quantite;
            this.prix = prix;
        }
        #endregion

        #region Getters/Setters
        [JsonProperty("userId")]
        public int UserId { get => userId; set => userId = value; }

        [JsonProperty("produitId")]
        public int ProduitId { get => produitId; set => produitId = value; }

        [JsonProperty("quantite")]
        public int Quantite { get => quantite; set => quantite = value; }

        [JsonProperty("prix")]
        public int Prix { get => prix; set => prix = value; }


        #endregion

        #region methodes

        #endregion
    }
}
