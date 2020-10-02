using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HP.HPTRIM.SDK;

namespace defaultcontaineraddin
{
    public class DefaultContainerAddin : ITrimAddIn
    {
        public override string ErrorMessage => throw new NotImplementedException();

        public override void ExecuteLink(int cmdId, TrimMainObject forObject, ref bool itemWasChanged)
        {

        }

        public override void ExecuteLink(int cmdId, TrimMainObjectSearch forTaggedObjects)
        {

        }

        public override TrimMenuLink[] GetMenuLinks()
        {
            TrimMenuLink[] links = new TrimMenuLink[] {};
            return links;
        }

        public override void Initialise(Database db)
        {

        }

        public override bool IsMenuItemEnabled(int cmdId, TrimMainObject forObject)
        {
            return true;
        }

        public override void PostDelete(TrimMainObject deletedObject)
        {

        }

        public override void PostSave(TrimMainObject savedObject, bool itemWasJustCreated)
        {

        }

        public override bool PreDelete(TrimMainObject modifiedObject)
        {
            return true;
        }

        public override bool PreSave(TrimMainObject modifiedObject)
        {
            return true;
        }

        public override bool SelectFieldValue(FieldDefinition field, TrimMainObject trimObject, string previousValue)
        {
            return true;
        }

        public override void Setup(TrimMainObject newObject)
        {
            Record rec = (Record)newObject;
            string rType = rec.RecordType.Uri.ToString();
            string rCon = GetContainer(rType);

            if(rCon != "")
            {
                rec.Container = (Record)rec.Database.FindTrimObjectByUri(BaseObjectTypes.Record, Convert.ToInt64(rCon));

            }
        }

        public string GetContainer(string searchRecType)
        {
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var strLines = File.ReadLines(assemblyFolder + "\\config.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[0].Equals(searchRecType))
                    return line.Split(',')[1];
            }

            return "";
        }

        public override bool SupportsField(FieldDefinition field)
        {
            return true;
        }

        public override bool VerifyFieldValue(FieldDefinition field, TrimMainObject trimObject, string newValue)
        {
            return true;
        }
    }
}

