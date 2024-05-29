using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id { get; set; }


    [Required(ErrorMessage = "titulo Invalido")]
    [MaxLength(80, ErrorMessage = "O titulo deve conter no maximo 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "titulo Invalido")]
    public string Description { get; set; } = string.Empty;
}

