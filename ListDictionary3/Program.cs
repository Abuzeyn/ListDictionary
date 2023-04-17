using ListDictionary3;

Dictionary<string, int> namesEndSales = new Dictionary<string, int>();
namesEndSales.Add("Ivan", 550);
namesEndSales.Add("Mamed", 630);
namesEndSales.Add("Mariya", 570);
namesEndSales.Add("Lala", 530);
namesEndSales.Add("Azer", 600);
namesEndSales.Add("Natalya", 590);



int salesPlan = 560;
ListOfNames.WriteOutLessPlan(namesEndSales, salesPlan);