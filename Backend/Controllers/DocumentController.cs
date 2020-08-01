using System.Collections.Generic;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private DocumentManagerContext _context;
        public DocumentController(DocumentManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Document> Get()
        {
            return _context.Document;
        }

        [HttpPost]
        public void Post(Document document)
        {
            _context.Document.Add(document);
            _context.SaveChanges();
        }
    }
}
