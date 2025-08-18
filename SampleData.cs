using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App_Project
{
    public static class SampleData
    {
        public static BindingList<Transaction> CreateSampleMonth()
        {

            var sampleMonth = new BindingList<Transaction>
            {
                // Allow new parts to be added, but not removed once committed.        
                AllowNew = true,
                AllowRemove = true,

                // Raise ListChanged events when new parts are added.
                RaiseListChangedEvents = true,

                // Do not allow parts to be edited.
                AllowEdit = true
            };

            sampleMonth.Add(new Transaction(1, 1500, "1st Pay Day"));
            sampleMonth.Add(new Transaction(15, 1500, "2nd Pay Day"));
            sampleMonth.Add(new Transaction(3, 150, "Electric Bill"));
            sampleMonth.Add(new Transaction(17, 16, "Netflix bill"));

            return sampleMonth;

        }
    }
}
