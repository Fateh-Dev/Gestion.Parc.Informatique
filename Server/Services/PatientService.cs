namespace Gestion.Parc.Informatique.Service;
using AutoMapper;
using Gestion.Parc.Informatique.Data;
using LinqKit;
using Microsoft.EntityFrameworkCore;
public class Patient
{

}
public class PagedPatientFilter
{

}
public class PatientReturnDto
{

}
public class PatientCreateDto
{

}
public interface IPatientService
{
    List<Patient> GetAllPatients();
    Task<PagedResultDto<Patient>> GetPagedPatientsByFliter(PagedPatientFilter filter);
    PatientReturnDto GetPatientById(Guid Id);
    void CreatePatient(PatientCreateDto Item);
    void UpdatePatient(Patient Item);
    void DeletePatientById(Guid Id);
    void ChangeMarqueOrder(int oldIndex, int newIndex);

}

public class PatientService : IPatientService
{
    private AppDbContext _context;
    private readonly IMapper _mapper;

    public PatientService(
        AppDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<Patient> GetAllPatients()
    {
        throw new NotImplementedException();
    }

    public async Task<PagedResultDto<Patient>> GetPagedPatientsByFliter(PagedPatientFilter filter)
    {
        var result = new PagedResultDto<Patient>();

        return result;
    }

    public PatientReturnDto GetPatientById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public void CreatePatient(PatientCreateDto Item)
    {
        throw new NotImplementedException();
    }

    public void UpdatePatient(Patient Item)
    {
        throw new NotImplementedException();
    }

    public void DeletePatientById(Guid Id)
    {
        throw new NotImplementedException();
    }
    //              1 2 3 4 5 6 7 8 9 10
    public void ChangeMarqueOrder(int oldIndex, int newIndex)
    {
        // If oldIndex > newIndex ----> successtion ++

        var currentMarque = _context.Marques.Where(o => o.Order == oldIndex).FirstOrDefault();
        if (oldIndex > newIndex)
        {
            var maruqesToChange = _context.Marques.Where(o => o.Order < oldIndex && o.Order >= newIndex).ToList();

            currentMarque.Order = newIndex;
            foreach (var item in maruqesToChange)
            {
                item.Order++;
            }
        }
        else
        {
            var maruqesToChange = _context.Marques.Where(o => o.Order > oldIndex && o.Order <= newIndex).ToList();

            currentMarque.Order = newIndex;
            foreach (var item in maruqesToChange)
            {
                item.Order--;
            }
        }
        _context.SaveChanges();
        // Else oldIndex < newIndex  --> Previous --
    }
}