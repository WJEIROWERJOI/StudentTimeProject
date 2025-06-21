using StudentTimeProject.Data.Entities;

namespace StudentTimeProject.Data.Services;

public static class Seeding
{
    public static async Task SeedingBoard(ApplicationDbContext context)
    {
        var logService = new LogService();


        if (!context.StudentClasses.Any() && !context.Students.Any() && !context.StudentTimes.Any())
        {
            var classes = new List<StudentClass>
{
    new StudentClass { Id = 1, Name = "중2반",Description="시딩중2반" },
    new StudentClass { Id = 2, Name = "고1반",Description="시딩고1반" },
    new StudentClass { Id = 3, Name = "고3반",Description="시딩고3반" }
};





            List<Student> students = new()
    {
        // 중2 (Middle2)
        new Student { Name = "정준규", Description = "정준규 (중2)", StudentGrade = StudentGrade.Middle2,ClassId = 1,Class=classes[0]},
        new Student { Name = "오윤서", Description = "오윤서 (중2)", StudentGrade = StudentGrade.Middle2,ClassId = 1,Class=classes[0]},
        new Student { Name = "임예지", Description = "임예지 (중2)", StudentGrade = StudentGrade.Middle2,ClassId = 1,Class=classes[0]},
        new Student { Name = "김정인", Description = "김정인 (중2)", StudentGrade = StudentGrade.Middle2,ClassId = 1,Class=classes[0]},
        new Student { Name = "박민재", Description = "박민재 (중2)", StudentGrade = StudentGrade.Middle2,ClassId = 1,Class=classes[0]},

        // 고1 (High1)
        new Student { Name = "이승현", Description = "이승현 (고1)", StudentGrade = StudentGrade.High1,ClassId = 2,Class=classes[1] },
        new Student { Name = "장재혁", Description = "장재혁 (고1)", StudentGrade = StudentGrade.High1,ClassId = 2,Class=classes[1]  },
        new Student { Name = "문지석", Description = "문지석 (고1)", StudentGrade = StudentGrade.High1,ClassId = 2,Class=classes[1]  },
        new Student { Name = "이소민", Description = "이소민 (고1)", StudentGrade = StudentGrade.High1,ClassId = 2,Class=classes[1]  },
        new Student { Name = "최소정", Description = "최소정 (고1)", StudentGrade = StudentGrade.High1,ClassId = 2,Class=classes[1]  },
        new Student { Name = "최동현", Description = "최동현 (고1)", StudentGrade = StudentGrade.High1,ClassId = 2,Class=classes[1]  },

        // 고3 (High3)
        new Student { Name = "김서연", Description = "김서연 (고3)", StudentGrade = StudentGrade.High3,ClassId = 3,Class=classes[2]  },
        new Student { Name = "김인주", Description = "김인주 (고3)", StudentGrade = StudentGrade.High3,ClassId = 3,Class=classes[2] },
        new Student { Name = "김현우", Description = "김현우 (고3)", StudentGrade = StudentGrade.High3,ClassId = 3,Class=classes[2] },
        new Student { Name = "진무겸", Description = "진무겸 (고3)", StudentGrade = StudentGrade.High3,ClassId = 3,Class=classes[2] },
        new Student { Name = "김준엽", Description = "김준엽 (고3)", StudentGrade = StudentGrade.High3 ,ClassId = 3,Class=classes[2]},
        new Student { Name = "오근택", Description = "오근택 (고3)", StudentGrade = StudentGrade.High3,ClassId = 3,Class=classes[2] },
        new Student { Name = "정현준", Description = "정현준 (고3)", StudentGrade = StudentGrade.High3 ,ClassId = 3,Class=classes[2]},
        new Student { Name = "김새롬", Description = "김새롬 (고3)", StudentGrade = StudentGrade.High3,ClassId = 3,Class=classes[2] }
    };


            List<StudentTime> studenttimes = new()
{
    // 정준규
    new StudentTime { Student = students.First(s => s.Name == "정준규"), StudentId = students.First(s => s.Name == "정준규").Id, Description = "영어", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Parse("16:30"), EndTime = TimeSpan.Parse("18:00") },
    new StudentTime { Student = students.First(s => s.Name == "정준규"), StudentId = students.First(s => s.Name == "정준규").Id,Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("16:30"), EndTime = TimeSpan.Parse("18:00") },

    // 오윤서
    new StudentTime { Student = students.First(s => s.Name == "오윤서"), StudentId = students.First(s => s.Name == "오윤서").Id, Description = "영어", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Parse("11:00"), EndTime = TimeSpan.Parse("13:00") },
    new StudentTime { Student = students.First(s => s.Name == "오윤서"), StudentId = students.First(s => s.Name == "오윤서").Id, Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("11:00"), EndTime = TimeSpan.Parse("13:00") },
    new StudentTime { Student = students.First(s => s.Name == "오윤서"), StudentId = students.First(s => s.Name == "오윤서").Id, Description = "국어", DayOfWeek = DayOfWeek.Thursday, StartTime = TimeSpan.Parse("13:00"), EndTime = TimeSpan.Parse("14:00") },
    new StudentTime { Student = students.First(s => s.Name == "오윤서"), StudentId = students.First(s => s.Name == "오윤서").Id,  Description = "국어", DayOfWeek = DayOfWeek.Friday, StartTime = TimeSpan.Parse("13:00"), EndTime = TimeSpan.Parse("14:00") },

    // 임예지
    new StudentTime { Student = students.First(s => s.Name == "임예지"), StudentId = students.First(s => s.Name == "임예지").Id,  Description = "국어", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Parse("16:00"), EndTime = TimeSpan.Parse("18:00") },
    new StudentTime { Student = students.First(s => s.Name == "임예지"), StudentId = students.First(s => s.Name == "임예지").Id,  Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("16:00"), EndTime = TimeSpan.Parse("18:00") },
    new StudentTime { Student = students.First(s => s.Name == "임예지"), StudentId = students.First(s => s.Name == "임예지").Id, Description = "영어", DayOfWeek = DayOfWeek.Saturday, StartTime = TimeSpan.Parse("11:00"), EndTime = TimeSpan.Parse("13:00") },

    // 김정인
    new StudentTime { Student = students.First(s => s.Name == "김정인"), StudentId = students.First(s => s.Name == "김정인").Id, Description = "영어", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("19:30") },
    new StudentTime { Student = students.First(s => s.Name == "김정인"), StudentId = students.First(s => s.Name == "김정인").Id, Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("19:30") },
    new StudentTime { Student = students.First(s => s.Name == "김정인"), StudentId = students.First(s => s.Name == "김정인").Id, Description = "영어", DayOfWeek = DayOfWeek.Friday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("19:30") },

    // 박민재
    new StudentTime { Student = students.First(s => s.Name == "박민재"), StudentId = students.First(s => s.Name == "박민재").Id, Description = "영어", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("19:35") },
    new StudentTime { Student = students.First(s => s.Name == "박민재"), StudentId = students.First(s => s.Name == "박민재").Id,Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("19:35") },
    new StudentTime { Student = students.First(s => s.Name == "박민재"), StudentId = students.First(s => s.Name == "박민재").Id, Description = "영어", DayOfWeek = DayOfWeek.Friday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("19:35") },
    // 고1: 이승현
new StudentTime { Student = students.First(s => s.Name == "이승현"), StudentId = students.First(s => s.Name == "이승현").Id,  Description = "영어", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Parse("17:30"), EndTime = TimeSpan.Parse("19:00") },
new StudentTime { Student = students.First(s => s.Name == "이승현"), StudentId = students.First(s => s.Name == "이승현").Id,  Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("19:00"), EndTime = TimeSpan.Parse("20:30") },
new StudentTime { Student = students.First(s => s.Name == "이승현"), StudentId = students.First(s => s.Name == "이승현").Id,  Description = "영어", DayOfWeek = DayOfWeek.Tuesday, StartTime = TimeSpan.Parse("14:00"), EndTime = TimeSpan.Parse("15:30") },
new StudentTime { Student = students.First(s => s.Name == "이승현"), StudentId = students.First(s => s.Name == "이승현").Id,  Description = "영어", DayOfWeek = DayOfWeek.Thursday, StartTime = TimeSpan.Parse("14:00"), EndTime = TimeSpan.Parse("15:30") },
new StudentTime { Student = students.First(s => s.Name == "이승현"), StudentId = students.First(s => s.Name == "이승현").Id,  Description = "국어", DayOfWeek = DayOfWeek.Saturday, StartTime = TimeSpan.Parse("10:00"), EndTime = TimeSpan.Parse("13:00") },

// 고1: 장재혁
new StudentTime { Student = students.First(s => s.Name == "장재혁"), StudentId = students.First(s => s.Name == "장재혁").Id, Description = "영어 (2층)", DayOfWeek = DayOfWeek.Tuesday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "장재혁"), StudentId = students.First(s => s.Name == "장재혁").Id, Description = "영어 (2층)", DayOfWeek = DayOfWeek.Friday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "장재혁"), StudentId = students.First(s => s.Name == "장재혁").Id,  Description = "영어 (2층)", DayOfWeek = DayOfWeek.Saturday, StartTime = TimeSpan.Parse("10:00"), EndTime = TimeSpan.Parse("12:00") },

// 고1: 문지석
new StudentTime { Student = students.First(s => s.Name == "문지석"), StudentId = students.First(s => s.Name == "문지석").Id,  Description = "영어 (2층)", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "문지석"), StudentId = students.First(s => s.Name == "문지석").Id, Description = "영어 (2층)", DayOfWeek = DayOfWeek.Friday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("20:00") },
new StudentTime { Student = students.First(s => s.Name == "문지석"), StudentId = students.First(s => s.Name == "문지석").Id, Description = "영어 (2층)", DayOfWeek = DayOfWeek.Saturday, StartTime = TimeSpan.Parse("10:30"), EndTime = TimeSpan.Parse("14:30") },

// 고1: 이소민
// 👉 월요일 종합이라고만 되어있으니, 일단 블랭크로 줄게요
new StudentTime { Student = students.First(s => s.Name == "이소민"), StudentId = students.First(s => s.Name == "이소민").Id,  Description = "종합", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Zero, EndTime = TimeSpan.Zero },

// 고1: 최소정
new StudentTime { Student = students.First(s => s.Name == "최소정"), StudentId = students.First(s => s.Name == "최소정").Id, Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("20:00") },
new StudentTime { Student = students.First(s => s.Name == "최소정"), StudentId = students.First(s => s.Name == "최소정").Id,  Description = "영어", DayOfWeek = DayOfWeek.Friday, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("20:00") },

// 고1: 최동현
new StudentTime { Student = students.First(s => s.Name == "최동현"), StudentId = students.First(s => s.Name == "최동현").Id,  Description = "영어 (2층)", DayOfWeek = DayOfWeek.Tuesday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "최동현"), StudentId = students.First(s => s.Name == "최동현").Id,  Description = "영어 (2층)", DayOfWeek = DayOfWeek.Friday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "최동현"), StudentId = students.First(s => s.Name == "최동현").Id,  Description = "국어", DayOfWeek = DayOfWeek.Sunday, StartTime = TimeSpan.Parse("17:00"), EndTime = TimeSpan.Parse("20:00") },
// 고3: 김서연
new StudentTime { Student = students.First(s => s.Name == "김서연"), StudentId = students.First(s => s.Name == "김서연").Id,  Description = "영어", DayOfWeek = DayOfWeek.Tuesday, StartTime = TimeSpan.Parse("18:30"), EndTime = TimeSpan.Parse("20:30") },
new StudentTime { Student = students.First(s => s.Name == "김서연"), StudentId = students.First(s => s.Name == "김서연").Id, Description = "영어", DayOfWeek = DayOfWeek.Saturday, StartTime = TimeSpan.Parse("12:00"), EndTime = TimeSpan.Parse("14:30") },

// 고3: 김인주
new StudentTime { Student = students.First(s => s.Name == "김인주"), StudentId = students.First(s => s.Name == "김인주").Id,  Description = "영어", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "김인주"), StudentId = students.First(s => s.Name == "김인주").Id, Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },

// 고3: 김현우
new StudentTime { Student = students.First(s => s.Name == "김현우"), StudentId = students.First(s => s.Name == "김현우").Id,  Description = "영어", DayOfWeek = DayOfWeek.Tuesday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "김현우"), StudentId = students.First(s => s.Name == "김현우").Id,  Description = "영어", DayOfWeek = DayOfWeek.Thursday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },

// 고3: 진무겸
new StudentTime { Student = students.First(s => s.Name == "진무겸"), StudentId = students.First(s => s.Name == "진무겸").Id, Description = "영어", DayOfWeek = DayOfWeek.Tuesday, StartTime = TimeSpan.Parse("17:30"), EndTime = TimeSpan.Parse("19:00") },
new StudentTime { Student = students.First(s => s.Name == "진무겸"), StudentId = students.First(s => s.Name == "진무겸").Id,  Description = "영어", DayOfWeek = DayOfWeek.Thursday, StartTime = TimeSpan.Parse("17:30"), EndTime = TimeSpan.Parse("19:00") },
new StudentTime { Student = students.First(s => s.Name == "진무겸"), StudentId = students.First(s => s.Name == "진무겸").Id,  Description = "영어", DayOfWeek = DayOfWeek.Saturday, StartTime = TimeSpan.Parse("12:40"), EndTime = TimeSpan.Parse("14:00") },

// 고3: 김준엽
new StudentTime { Student = students.First(s => s.Name == "김준엽"), StudentId = students.First(s => s.Name == "김준엽").Id,  Description = "영어", DayOfWeek = DayOfWeek.Tuesday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "김준엽"), StudentId = students.First(s => s.Name == "김준엽").Id,  Description = "영어", DayOfWeek = DayOfWeek.Thursday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "김준엽"), StudentId = students.First(s => s.Name == "김준엽").Id, Description = "영어", DayOfWeek = DayOfWeek.Saturday, StartTime = TimeSpan.Parse("12:40"), EndTime = TimeSpan.Parse("14:00") },

// 고3: 오근택
new StudentTime { Student = students.First(s => s.Name == "오근택"), StudentId = students.First(s => s.Name == "오근택").Id,  Description = "영어", DayOfWeek = DayOfWeek.Monday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },
new StudentTime { Student = students.First(s => s.Name == "오근택"), StudentId = students.First(s => s.Name == "오근택").Id,  Description = "영어", DayOfWeek = DayOfWeek.Wednesday, StartTime = TimeSpan.Parse("20:00"), EndTime = TimeSpan.Parse("22:00") },

// 고3: 정현준 → 없음
// 고3: 김새롬 → 없음
};


            context.StudentClasses.AddRange(classes);
            context.Students.AddRange(students);
            context.StudentTimes.AddRange(studenttimes);
            await context.SaveChangesAsync();
        }

    }


}