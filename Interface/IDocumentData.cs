using ParishApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Interface
{
    public interface IDocumentData
    {
        MST_Documents AddDocument(MST_Documents model);

        MST_Documents EditDocuments(MST_Documents model);

        string DeleteDocuments(int docID);

        List<MST_Documents> FetchAllDocs();

        MST_Documents GetSingleDocument(int docId);
    }
}
