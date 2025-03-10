using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dantecMarket.Modeles
{
    public class Produit
    {

        #region Attributs
        private int id;
        private string nomProduit;
        private string description;
        private double prix;
        private int quantiteDisponible;
        private List<ImageProduit> lesImages;
        private Categorie laCategorie;
        private string descriptioncourte;
        private int etoiles;
        private int nbvotes;
        private int nbAvis;
        private int points;
        private DateTime dateCreation;
        #endregion

        #region Constructeurs
        public Produit(int id, string nomProduit, string description, double prix, int quantiteDisponible, List<ImageProduit> lesImages, Categorie laCategorie, string descriptioncourte, int etoiles, int nbvotes, int nbAvis, int points, DateTime dateCreation)
        {
            this.id = id;
            this.nomProduit = nomProduit;
            this.description = description;
            this.prix = prix;
            this.quantiteDisponible = quantiteDisponible;
            this.lesImages = lesImages;
            this.laCategorie = laCategorie;
            this.descriptioncourte = descriptioncourte;
            this.etoiles = etoiles;
            this.nbvotes = nbvotes;
            this.nbAvis = nbAvis;
            this.points = points;
            this.dateCreation = dateCreation;
        }
        #endregion

        #region Getters/Setters
        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }
        [JsonProperty("nomProduit")]
        public string NomProduit { get => nomProduit; set => nomProduit = value; }
        [JsonProperty("description")]
        public string Description { get => description; set => description = value; }
        [JsonProperty("prix")]
        public double Prix { get => prix; set => prix = value; }
        [JsonProperty("quantiteDisponible")]
        public int QuantiteDisponible { get => quantiteDisponible; set => quantiteDisponible = value; }
        [JsonProperty("lesImages")]
        public List<ImageProduit> LesImages { get => lesImages; set => lesImages = value; }
        [JsonProperty("laCategorie")]
        public Categorie LaCategorie { get => laCategorie; set => laCategorie = value; }
        [JsonProperty("descriptioncourte")]
        public string DescriptionCourte { get => descriptioncourte; set => descriptioncourte = value; }
        [JsonProperty("etoiles")]
        public int Etoiles { get => etoiles; set => etoiles = value; }
        [JsonProperty("nbvotes")]
        public int NbVotes { get => nbvotes; set => nbvotes = value; }
        [JsonProperty("nbAvis")]
        public int NbAvis { get => nbAvis; set => nbAvis = value; }
        [JsonProperty("points")]
        public int Points { get => points; set => points = value; }
        [JsonProperty("dateCreation")]
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        #endregion

        #region methodes
      
        #endregion
    }

    public class ImageProduit
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("imageName")]
        public string ImageName { get; set; }
    }
}
