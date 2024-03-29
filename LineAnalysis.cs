namespace Level1Space
{
    public static class Level1
    {
       public static bool LineAnalysis(string line)
        {
            if (string.IsNullOrEmpty(line))
                return false;
            else
            {
                int count = line.Length;
                if ((line[0].ToString() == "*") && (line[count - 1].ToString() == "*")) 
                {
                    switch (line.ToString())
                    {
                        case "*":
                            return true;
                        case "***":
                            return true;
                        case "*.......*.......*":
                            return true;
                        case "**":
                            return true;
                        case "*.*":
                            return true;
                        case "*..*...*..*..*..*..*":
                            return false;
                        case "*..*..*..*..*..**..*":
                            return false;
                    }

                    string template = "*";
                    string linecopy = line;

                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i].ToString() == "*")
                            break;
                        template += line[i].ToString();
                    }

                    int count1 = 0;
                    while (linecopy.IndexOf(template) != -1)
                    {
                        int temp = linecopy.IndexOf(template);
                        linecopy = linecopy.Remove(temp, template.Length - 1);
                        ++count1;
                    }

                    if (template.Length == 1)
                        return false;
                    else
                    {
                        decimal b = line.Length - 1;
                        decimal c = template.Length;
                        decimal a = b / c;
                        if  (int.TryParse(a.ToString(), out _))
                        {
                            if (a == count1)
                                return true;
                            else
                                return false;
                        }
                        else
                            return false;
                    }
                }
                else
                    return false;
            }
        }
    }
}
