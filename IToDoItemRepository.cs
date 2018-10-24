namespace ViewInjectSample.Models.Services
{
    public interface IToDoItemRepository
    {
        object List();
        object Count();
    }
}