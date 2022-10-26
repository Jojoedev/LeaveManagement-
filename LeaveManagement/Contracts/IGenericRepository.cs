namespace LeaveManagement.Repository
{
    public interface IGenericRepository<T> where T : class 
        //Generic allows more than one class type implementation
    {
        //Declare methods that will be used by the application.
        //Cuz this is async op, Task will apply

        Task<T> GetAsync(int? id);

        Task<List<T>> GetAllAsync();
       
        Task<T> CreateAsync(T entity);
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);


    }
}
