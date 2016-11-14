using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz3AnimalCare
{
    public partial class Search : System.Web.UI.Page
    {
        public AnimalCareDataContext animalCareDb = new AnimalCareDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btVetNameAddPC_Click(object sender, EventArgs e)
        {
            var vetNameAddPC = tbVetNameAddPC.Text;
            gvResult.DataSource = from Veterinarian in animalCareDb.Veterinarians
                                  where Veterinarian.Name.Contains(vetNameAddPC) || Veterinarian.Address.Contains(vetNameAddPC) || Veterinarian.PostalCode.Contains(vetNameAddPC)
                                  select Veterinarian;
            gvResult.DataBind();
        }

        protected void btNameOrRace_Click(object sender, EventArgs e)
        {
            var nameOrRace = tbNameOrRace.Text;
            gvResult.DataSource = from Animal in animalCareDb.Animals
                                  where Animal.Name.Contains(nameOrRace) || Animal.RaceBreed.Contains(nameOrRace)
                                  select Animal;
            gvResult.DataBind();
        }

        protected void btAnVetPC_Click(object sender, EventArgs e)
        {
            var anVetPC = tbAnVetPC.Text;
            gvResult.DataSource =
                from Animal in animalCareDb.Animals.Distinct()
                from mappings in animalCareDb.Veterinarians
                    .Where(mapping => mapping.Id == Animal.VetId && mapping.PostalCode.Contains(anVetPC))
                from Veterinarian in animalCareDb.Veterinarians
                    .Where(gruppe => gruppe.PostalCode.Contains(anVetPC))
                select new
                {
                    Animal = Animal.RaceBreed
                    ,
                    Veterinarian = mappings.Name
                } ;
            gvResult.DataBind();
        }
    }
}