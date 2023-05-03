using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using stacktimm.Data;
using stacktimm.Models.Domain;
using stacktimm.Models.ViewModels;

namespace stacktimm.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {
        private readonly stacktimmDbContext stacktimmDbContext;

        [BindProperty]
        public AddPost AddPostRequest { get; set; }

        public AddModel(stacktimmDbContext stacktimmDbContext)
        {
            this.stacktimmDbContext = stacktimmDbContext;
           
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var ajouterPost = new Ressource()
            {
                CodeRessource = AddPostRequest.Titre,
                Url = AddPostRequest.Url,
                CodeConnaissance = AddPostRequest.Connaissance,
                CodeTypeRessource = AddPostRequest.Type
            };
            stacktimmDbContext.Ressources.Add(ajouterPost);
            stacktimmDbContext.SaveChanges();
        }
    }
}
