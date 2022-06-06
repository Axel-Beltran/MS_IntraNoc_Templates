using Izzi.Noc.DAO.Interfaces;
using Izzi.Noc.DAO.Abstract;
using Izzi.Noc.Entities.DataStructure;

namespace Izzi.Noc.DAO.Objects
{
    public class TemplateDAOImpl : GenericDAO<Template, int>, ITemplateDAO
    {
        public bool existById(int templateId)
        {
            Template template = new Template();
            template = base.GetById(templateId);
            return template != null ? true : false;
        }
    }
}
