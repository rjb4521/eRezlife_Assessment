using System;
using System.Collections.Generic;
using System.Text;

namespace eRezlife_Assessment
{
    class Problem1
    {
        //  SELECT s.id, s.name, a.id
        //  FROM students s
        //  INNER JOIN (
        //          Select student_id, count(id) as totalApplications
        //          From application
        //          GROUP BY student_id
        //          ) as a on a.student_id ON s.id
        //          ORDER BY r totalApplications DESC, s.name
    }
}
