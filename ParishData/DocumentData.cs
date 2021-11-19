using ParishApi.Entity;
using ParishApi.Interface;
using ParishApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.ParishData
{
    public class DocumentData : IDocumentData
    {
        private ParishContext _parishContext;

        public DocumentData(ParishContext parishContext)
        {
            _parishContext = parishContext;
        }
        public MST_Documents AddDocument(MST_Documents model)
        {
            _parishContext.MST_Documents.Add(model);
            _parishContext.SaveChanges();
            return model;
        }

        public string DeleteDocuments(int docID)
        {
            string msg = string.Empty;
            var existingDoc = _parishContext.MST_Documents.Find(docID);
            if (existingDoc != null)
            {
                _parishContext.MST_Documents.Remove(existingDoc);
                _parishContext.SaveChanges();
                msg = "Deleted Successfully";
                return msg;
            }
            else
            {
                msg = "No such family member exist!";
                return msg;
            }
        }

        public MST_Documents EditDocuments(MST_Documents model)
        {
            var existingDoc = _parishContext.MST_Documents.Find(model.docid);
            if (existingDoc != null)
            {
                _parishContext.MST_Documents.Update(model);
                _parishContext.SaveChanges();
            }
            return model;
        }
        public List<MST_Documents> FetchAllDocs() => _parishContext.MST_Documents.ToList();

        public MST_Documents GetSingleDocument(int docId) => _parishContext.MST_Documents.Find(docId);
    }
}
