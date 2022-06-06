using Izzi.Noc.Business.Interfaces;
using Izzi.Noc.DAO.Interfaces;
using Izzi.Noc.DAO.Objects;

namespace Izzi.Noc.Business.Objects
{
    public class TemplatesExtendedImpl : ITemplatesExtended
    {
        ITemplateDAO templateDAO;

        public TemplatesExtendedImpl()
        {
            templateDAO = new TemplateDAOImpl();
        }
        public bool existTemplateById(int templateId)
        {
            return templateDAO.existById(templateId);
        }
    }
}
