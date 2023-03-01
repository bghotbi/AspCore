using AspCore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspCore.Pages;

public class ProductsModel : PageModel
{
    private readonly IProductRepository _repo;
    private readonly ILogger<IndexModel> _logger;

    public ProductsModel(IProductRepository repo, ILogger<IndexModel> logger)
    {
        _repo = repo;
        _logger = logger;
    }

    public void OnGet()
    {

    }
}