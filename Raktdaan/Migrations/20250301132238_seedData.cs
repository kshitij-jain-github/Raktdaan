using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Raktdaan.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Blood_group", "City", "ConcurrencyStamp", "Country", "Discriminator", "Email", "EmailConfirmed", "Full_Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "A+", "Gaziabad", "315077ce-84cc-4e4b-8bb6-4905f1ad5937", "India", "ApplicationUser", "rohit.bansal1@gmail.com", true, "Rohit Bansal", false, null, "ROHIT.BANSAL1@GMAIL.COM", "ROHIT.BANSAL1@GMAIL.COM", "AQAAAAIAAYagAAAAEECI16yy0ALs1rGMRzZWP67PJnbJSQGJ4FmWVHHW3lRZ+VaXUq0SOViejs0dxGMa/g==", null, "123-456-7890", false, null, "98312557-065d-4081-8483-d7ba19927d99", "New Delhi", false, "rohit.bansal1@gmail.com" },
                    { "10", 0, null, "A-", "Gaziabad", "9d02b03f-f9c3-4ecd-a144-50165e8a1d79", "India", "ApplicationUser", "tanisha.jain10@gmail.com", true, "Tanisha Jain", false, null, "TANISHA.JAIN10@GMAIL.COM", "TANISHA.JAIN10@GMAIL.COM", "AQAAAAIAAYagAAAAEDPebyFCd3MYzG0Ks9lm+0ZVz7m3TGfD5m8oM4AbwFAlZ7ckskQIe70dwrw0S5DlUw==", null, "123-456-7890", false, null, "778ad924-4c40-4052-94bb-f4f6d56080a9", "Banglore", false, "tanisha.jain10@gmail.com" },
                    { "100", 0, null, "B-", "Gaziabad", "f1c27e18-29f0-4048-890d-cad2e8982a32", "India", "ApplicationUser", "nisha.sharma100@gmail.com", true, "Nisha Sharma", false, null, "NISHA.SHARMA100@GMAIL.COM", "NISHA.SHARMA100@GMAIL.COM", "AQAAAAIAAYagAAAAEPltfeGJWpzgpvnHqHr0MunnQjg0WtvFxQBlHXk64uEQlTlHjeY5AS+ORH1zVbpwzQ==", null, "123-456-7890", false, null, "2ebe556d-be74-4205-a820-870c467a39de", "Banglore", false, "nisha.sharma100@gmail.com" },
                    { "11", 0, null, "B+", "Noida", "bbbce361-e772-407f-9941-89baf7344335", "India", "ApplicationUser", "manya.goyal11@gmail.com", true, "Manya Goyal", false, null, "MANYA.GOYAL11@GMAIL.COM", "MANYA.GOYAL11@GMAIL.COM", "AQAAAAIAAYagAAAAEG30hv/wkNHFyoTSr2LLVbom3VQvH0zDj0xi7l862EcQb5eHirMr30zyfAUmbkWrVQ==", null, "123-456-7890", false, null, "c7898cec-323e-467c-b1e0-65b4bc503562", "U.P", false, "manya.goyal11@gmail.com" },
                    { "12", 0, null, "B-", "Faridabad", "e97f8084-8779-4f50-b139-0c325d7b0ae8", "India", "ApplicationUser", "khushi.sharma12@gmail.com", true, "Khushi Sharma", false, null, "KHUSHI.SHARMA12@GMAIL.COM", "KHUSHI.SHARMA12@GMAIL.COM", "AQAAAAIAAYagAAAAEKy6dbxFngcFJN146Ymy3JVzEGQcIcCfUmMH4fXx8OaffJcdGWYTP/2PJaw8yAB+vg==", null, "123-456-7890", false, null, "4af85300-4fae-4ef8-a766-221371d15ee2", "Haryana", false, "khushi.sharma12@gmail.com" },
                    { "13", 0, null, "O+", "Shahdara", "a8ed77dd-86e9-4cfc-b6f0-4d50a9854ce7", "India", "ApplicationUser", "kritika.gupta13@gmail.com", true, "Kritika Gupta", false, null, "KRITIKA.GUPTA13@GMAIL.COM", "KRITIKA.GUPTA13@GMAIL.COM", "AQAAAAIAAYagAAAAEKL4k9BSPOswSD767sV0YqbmqxRleu3NxJuYTLrAgXMbqsMLc1LbxKujF9ckhPUG+Q==", null, "123-456-7890", false, null, "f143d36b-cecd-4d00-a832-46330de8c056", "New Delhi", false, "kritika.gupta13@gmail.com" },
                    { "14", 0, null, "O-", "Rohini", "8d26a74c-d52e-4b94-ac90-326a4c058cb5", "India", "ApplicationUser", "preeti.prakash14@gmail.com", true, "Preeti Prakash", false, null, "PREETI.PRAKASH14@GMAIL.COM", "PREETI.PRAKASH14@GMAIL.COM", "AQAAAAIAAYagAAAAEKM6YHrGNE9QW7CEGTX8tsc+o5lFV+Yu3sDfDDwCf7N/pbVO0iE/35GzNOrG0r8iPw==", null, "123-456-7890", false, null, "13997c17-94e2-4261-a8b8-661081a0dfa7", "Mumbai", false, "preeti.prakash14@gmail.com" },
                    { "15", 0, null, "AB+", "Patel Nagar", "6f4f78c0-1c0a-4839-8c07-6849c6e53ff9", "India", "ApplicationUser", "nisha.aggarwal15@gmail.com", true, "Nisha Aggarwal", false, null, "NISHA.AGGARWAL15@GMAIL.COM", "NISHA.AGGARWAL15@GMAIL.COM", "AQAAAAIAAYagAAAAEDThjIIumZgHmi+V7gKvdH4YbgHGVqPncb5nPJqE7Ak8GsXcoO0OEHmhlsVa4k3oCQ==", null, "123-456-7890", false, null, "eea21db4-10bd-4423-9cb6-f048028a32f0", "Chandigarh", false, "nisha.aggarwal15@gmail.com" },
                    { "16", 0, null, "AB-", "Dwarka", "b1cefaef-19ab-4c06-b189-837f45548412", "India", "ApplicationUser", "dhruv.singh16@gmail.com", true, "Dhruv Singh", false, null, "DHRUV.SINGH16@GMAIL.COM", "DHRUV.SINGH16@GMAIL.COM", "AQAAAAIAAYagAAAAEPC+uGZgkVDWwgAlc5hbz6N4A8NhKX2s0nEVVwEYXInL8HVd4INm6NGfDA8Z/wpvNg==", null, "123-456-7890", false, null, "dc91bfa3-847c-4488-8714-9b937e28e5df", "Banglore", false, "dhruv.singh16@gmail.com" },
                    { "17", 0, null, "A+", "Azadnagar", "3be479be-c7c0-4f88-a65b-5ba8526ed1db", "India", "ApplicationUser", "shubham.bansal17@gmail.com", true, "Shubham Bansal", false, null, "SHUBHAM.BANSAL17@GMAIL.COM", "SHUBHAM.BANSAL17@GMAIL.COM", "AQAAAAIAAYagAAAAEPUuE+7TtLwOqRD+fGakQmOD0vl1et+nodyWdwLbYyBm/eAxwm4ufYH57RvJ9BzE8g==", null, "123-456-7890", false, null, "df0fc9fb-8489-4470-a832-1ffdae6f8b05", "U.P", false, "shubham.bansal17@gmail.com" },
                    { "18", 0, null, "A-", "Krishna Nagar", "ff8dd6e0-85b0-4a6d-b8d8-3f1c98311c1f", "India", "ApplicationUser", "rohit.jain18@gmail.com", true, "Rohit Jain", false, null, "ROHIT.JAIN18@GMAIL.COM", "ROHIT.JAIN18@GMAIL.COM", "AQAAAAIAAYagAAAAEDL1oE5xOZ5gfJ8wUdvROLoXkLrGYaHBzDeacWfXkT2QbfZupUZWyvqIGNd1xpMsNA==", null, "123-456-7890", false, null, "b09af31d-df19-4922-8e34-5f2a5208b6a8", "Haryana", false, "rohit.jain18@gmail.com" },
                    { "19", 0, null, "B+", "Gaziabad", "4afbf773-3b07-4166-a64b-f9bd6d3e5f38", "India", "ApplicationUser", "kunal.goyal19@gmail.com", true, "Kunal Goyal", false, null, "KUNAL.GOYAL19@GMAIL.COM", "KUNAL.GOYAL19@GMAIL.COM", "AQAAAAIAAYagAAAAEA1Ql8DjDxelpwjRFCQCs6JKefwCGitWb+OloTkpf0qGiCMilmFAo6v2e1Sj/x8k/Q==", null, "123-456-7890", false, null, "77b3c94b-dbfc-43ae-8342-0a0466f157b9", "New Delhi", false, "kunal.goyal19@gmail.com" },
                    { "2", 0, null, "A-", "Noida", "0d064ae1-29e3-451f-9cb7-b15b41da2e1e", "India", "ApplicationUser", "kunal.jain2@gmail.com", true, "Kunal Jain", false, null, "KUNAL.JAIN2@GMAIL.COM", "KUNAL.JAIN2@GMAIL.COM", "AQAAAAIAAYagAAAAEOPdwwDWbljvajar9wu7wz/MkDL7hTMGmZ4BEjkJneZZE8r01b99/AjY1HtTwKrp/g==", null, "123-456-7890", false, null, "90181202-28f7-407f-9b16-1026bcb5f9b7", "Mumbai", false, "kunal.jain2@gmail.com" },
                    { "20", 0, null, "B-", "Noida", "17406456-a194-4d71-83bc-82ffa550e680", "India", "ApplicationUser", "arpit.sharma20@gmail.com", true, "Arpit Sharma", false, null, "ARPIT.SHARMA20@GMAIL.COM", "ARPIT.SHARMA20@GMAIL.COM", "AQAAAAIAAYagAAAAECzHoliza2otU1+bfrVlac57uFAH0LqWEUHujiDFuPCy8FzWYCcAJSYz+L2K/64ahQ==", null, "123-456-7890", false, null, "4806ef41-d0b7-4ad8-bf70-a9ead82cc7ec", "Mumbai", false, "arpit.sharma20@gmail.com" },
                    { "21", 0, null, "O+", "Faridabad", "7415c1db-8770-4f84-bab9-4c5e82ceb623", "India", "ApplicationUser", "yash.gupta21@gmail.com", true, "Yash Gupta", false, null, "YASH.GUPTA21@GMAIL.COM", "YASH.GUPTA21@GMAIL.COM", "AQAAAAIAAYagAAAAEKDqxtgrcR3dGABWTRH3g8UHi668oLbwLbbbbKcXPab/w7PGt/C6p34k5zm+c81ZPg==", null, "123-456-7890", false, null, "e151e234-ac3c-4c16-b337-4a17d165c39a", "Chandigarh", false, "yash.gupta21@gmail.com" },
                    { "22", 0, null, "O-", "Shahdara", "c843da63-61b3-4049-9f17-8b03058a0ba9", "India", "ApplicationUser", "vinay.prakash22@gmail.com", true, "Vinay Prakash", false, null, "VINAY.PRAKASH22@GMAIL.COM", "VINAY.PRAKASH22@GMAIL.COM", "AQAAAAIAAYagAAAAEDhz+ZIZIR6lySg344epJH38OrGFfuYBaTm901G7mOKvmcB9XF2sGDmmR5gRuyiyig==", null, "123-456-7890", false, null, "29643e3d-6c97-41e2-9b82-0b27711cee33", "Banglore", false, "vinay.prakash22@gmail.com" },
                    { "23", 0, null, "AB+", "Rohini", "45890e5c-d117-4a04-95f0-d962da20ec7d", "India", "ApplicationUser", "ritik.aggarwal23@gmail.com", true, "Ritik Aggarwal", false, null, "RITIK.AGGARWAL23@GMAIL.COM", "RITIK.AGGARWAL23@GMAIL.COM", "AQAAAAIAAYagAAAAEPywiknoJE7nZTJPGrU+mhaL+OtPFh6ntbmQ654VYu9Axs5NQmDm2eKyDcv5hifgvQ==", null, "123-456-7890", false, null, "c340174c-0009-48ab-a570-5e60591b8713", "U.P", false, "ritik.aggarwal23@gmail.com" },
                    { "24", 0, null, "AB-", "Patel Nagar", "015b462a-d905-48ec-a5c8-db778e97f86a", "India", "ApplicationUser", "jatin.singh24@gmail.com", true, "Jatin Singh", false, null, "JATIN.SINGH24@GMAIL.COM", "JATIN.SINGH24@GMAIL.COM", "AQAAAAIAAYagAAAAEJmt6kn5MvPjbAHAgpwFR/7TDvFCdBux2wkfmJRDs+3fppnIBtStGl/kjwhLC7LoqA==", null, "123-456-7890", false, null, "df9bda7d-a6ff-451e-b719-c603711bdc7f", "Haryana", false, "jatin.singh24@gmail.com" },
                    { "25", 0, null, "A+", "Dwarka", "424afb84-ea78-498c-b1d6-8165dd47e484", "India", "ApplicationUser", "sneha.bansal25@gmail.com", true, "Sneha Bansal", false, null, "SNEHA.BANSAL25@GMAIL.COM", "SNEHA.BANSAL25@GMAIL.COM", "AQAAAAIAAYagAAAAEKRMH51hYzGIZczcKPyHkEWWqZoMHJow4ZqUmQ3p37hZi+gZXmD0wgwaSl8aN0WHsw==", null, "123-456-7890", false, null, "34da7cc3-848d-4f37-bbf4-23b3670011af", "New Delhi", false, "sneha.bansal25@gmail.com" },
                    { "26", 0, null, "A-", "Azadnagar", "8d2780fa-e97b-4faf-baf5-09651c70ffd0", "India", "ApplicationUser", "monika.jain26@gmail.com", true, "Monika Jain", false, null, "MONIKA.JAIN26@GMAIL.COM", "MONIKA.JAIN26@GMAIL.COM", "AQAAAAIAAYagAAAAEKTuLoTWsmkKpsHsNvPgxZDUm7qTy+eBfSImPtBv+Lcu2hKPQ4eNrONlv67Ogw+q2w==", null, "123-456-7890", false, null, "6aaff2aa-083f-4e5f-9bcb-255faa3ee865", "Mumbai", false, "monika.jain26@gmail.com" },
                    { "27", 0, null, "B+", "Krishna Nagar", "cf469134-1cd1-4fa8-91b3-e9fb3d8480b8", "India", "ApplicationUser", "tanisha.goyal27@gmail.com", true, "Tanisha Goyal", false, null, "TANISHA.GOYAL27@GMAIL.COM", "TANISHA.GOYAL27@GMAIL.COM", "AQAAAAIAAYagAAAAEE7cmRi0HRNwtNHbY8L0nkE/YqyBG8rMQ5n36uzYWA0DK+aiC1jz+S4yydiM+aQojw==", null, "123-456-7890", false, null, "e3d5180a-118a-4f31-a536-ed15cb3fca14", "Chandigarh", false, "tanisha.goyal27@gmail.com" },
                    { "28", 0, null, "B-", "Gaziabad", "34a14549-130c-4d0a-bd4a-f572785623d6", "India", "ApplicationUser", "manya.sharma28@gmail.com", true, "Manya Sharma", false, null, "MANYA.SHARMA28@GMAIL.COM", "MANYA.SHARMA28@GMAIL.COM", "AQAAAAIAAYagAAAAEJYWduPw1BpUY3IOmh1osc+iv4gJLKgPAwHVg3i0WSkGDsBgGWJHJPyq3h6M5FWp5g==", null, "123-456-7890", false, null, "6e10ea4b-08c2-4b9b-ac71-11ff597accf7", "Banglore", false, "manya.sharma28@gmail.com" },
                    { "29", 0, null, "O+", "Noida", "e1fad3a8-2ae8-416d-88f1-3c794c23b73c", "India", "ApplicationUser", "khushi.gupta29@gmail.com", true, "Khushi Gupta", false, null, "KHUSHI.GUPTA29@GMAIL.COM", "KHUSHI.GUPTA29@GMAIL.COM", "AQAAAAIAAYagAAAAECBjK26tndvxVYh92xDpD55y7/92vuz0IZWpdk3jyNdyz9Rw1FWfy6H2DERfSl17SA==", null, "123-456-7890", false, null, "663f78aa-70aa-493c-bfcf-6d11371fd791", "U.P", false, "khushi.gupta29@gmail.com" },
                    { "3", 0, null, "B+", "Faridabad", "1cf8a864-fc32-4afe-9296-90d067d5dd3f", "India", "ApplicationUser", "arpit.goyal3@gmail.com", true, "Arpit Goyal", false, null, "ARPIT.GOYAL3@GMAIL.COM", "ARPIT.GOYAL3@GMAIL.COM", "AQAAAAIAAYagAAAAEP5GgorzJyEaQBU5j4svof320BCbz01cvpsUiPdcf1zuHKoObPplACva2DaJTlNVjQ==", null, "123-456-7890", false, null, "85e77193-4df5-4ec9-8181-b5b84a073728", "Chandigarh", false, "arpit.goyal3@gmail.com" },
                    { "30", 0, null, "O-", "Faridabad", "26fefe91-fdd5-4a52-9dde-59465e015bf9", "India", "ApplicationUser", "kritika.prakash30@gmail.com", true, "Kritika Prakash", false, null, "KRITIKA.PRAKASH30@GMAIL.COM", "KRITIKA.PRAKASH30@GMAIL.COM", "AQAAAAIAAYagAAAAEGrxhlyUjpnFlF/bHSf8lN9RABkswAEnxsUlUdPaUThgnCp+TIvA23s6aHBMvueMcA==", null, "123-456-7890", false, null, "57c4af36-0320-475f-848a-9c05038a51a8", "Haryana", false, "kritika.prakash30@gmail.com" },
                    { "31", 0, null, "AB+", "Shahdara", "ea358d3a-a8b6-41f4-9417-6dd16649b691", "India", "ApplicationUser", "preeti.aggarwal31@gmail.com", true, "Preeti Aggarwal", false, null, "PREETI.AGGARWAL31@GMAIL.COM", "PREETI.AGGARWAL31@GMAIL.COM", "AQAAAAIAAYagAAAAEGpH/tqNbE0YtRcgF4RXPzGT4lgaFmWQKztyZh5el3Ptf7RutVnvPulBCmTWJnOv9w==", null, "123-456-7890", false, null, "0aeb5f6a-8c6e-44fd-b64f-55fb00341953", "New Delhi", false, "preeti.aggarwal31@gmail.com" },
                    { "32", 0, null, "AB-", "Rohini", "3893f17e-6304-4ba8-ba64-4fbe0ab53e5c", "India", "ApplicationUser", "nisha.singh32@gmail.com", true, "Nisha Singh", false, null, "NISHA.SINGH32@GMAIL.COM", "NISHA.SINGH32@GMAIL.COM", "AQAAAAIAAYagAAAAEIZ7F8Npdua67X6cJzgu3LpbVhsxozYFd9OSNeCf0KH+eWyCKjEGnkMql88vzUMGdQ==", null, "123-456-7890", false, null, "e4577aa9-86cf-47e7-b173-6e68bb017594", "Mumbai", false, "nisha.singh32@gmail.com" },
                    { "33", 0, null, "A+", "Patel Nagar", "4a7fd627-ac31-448f-aaf1-5916bb09bff0", "India", "ApplicationUser", "dhruv.bansal33@gmail.com", true, "Dhruv Bansal", false, null, "DHRUV.BANSAL33@GMAIL.COM", "DHRUV.BANSAL33@GMAIL.COM", "AQAAAAIAAYagAAAAEJ/3cmrPRNLYUkbLgtjv4etCqP+a0Xcc6RCcWo1VjTj+r7oi8JNS9+cfPWUa1ELFUA==", null, "123-456-7890", false, null, "709cdd8f-6190-4695-a034-a92281ee356b", "Chandigarh", false, "dhruv.bansal33@gmail.com" },
                    { "34", 0, null, "A-", "Dwarka", "f0812b46-5b99-41c5-8b19-0c85b48f1419", "India", "ApplicationUser", "shubham.jain34@gmail.com", true, "Shubham Jain", false, null, "SHUBHAM.JAIN34@GMAIL.COM", "SHUBHAM.JAIN34@GMAIL.COM", "AQAAAAIAAYagAAAAEMjfDgexVoLBrYZLWz5LU6cWKl8QX7tewlv0GxXZ21nBCRpcfA68/ZVQGjYtXBq1iw==", null, "123-456-7890", false, null, "61b7d67d-ab61-44f0-8c24-edbba17d7192", "Banglore", false, "shubham.jain34@gmail.com" },
                    { "35", 0, null, "B+", "Azadnagar", "da0d2e61-0584-4cb9-ab21-b648a522405f", "India", "ApplicationUser", "rohit.goyal35@gmail.com", true, "Rohit Goyal", false, null, "ROHIT.GOYAL35@GMAIL.COM", "ROHIT.GOYAL35@GMAIL.COM", "AQAAAAIAAYagAAAAEGu/jh3V+qOIDKTIam/upkI2hXzWBqwogrXOs2Y0aVgZ3Sg4yLGOvD6wFbhOAHhfSg==", null, "123-456-7890", false, null, "77485abf-68a7-4daa-b9ae-e3eb943d8f20", "U.P", false, "rohit.goyal35@gmail.com" },
                    { "36", 0, null, "B-", "Krishna Nagar", "754ae6cb-920d-4438-9d6d-13e0ffc9cdf4", "India", "ApplicationUser", "kunal.sharma36@gmail.com", true, "Kunal Sharma", false, null, "KUNAL.SHARMA36@GMAIL.COM", "KUNAL.SHARMA36@GMAIL.COM", "AQAAAAIAAYagAAAAELKaaUbkkxxvkksAn+vQICSMwZd1dQMfaEI1EG5DyicNu82m1wq7qUUYp81Vfr9bMg==", null, "123-456-7890", false, null, "ad215bd3-705a-47bd-99ce-c15116b335ee", "Haryana", false, "kunal.sharma36@gmail.com" },
                    { "37", 0, null, "O+", "Gaziabad", "37b2ef67-a0a6-45bb-a3d4-be5949996ce0", "India", "ApplicationUser", "arpit.gupta37@gmail.com", true, "Arpit Gupta", false, null, "ARPIT.GUPTA37@GMAIL.COM", "ARPIT.GUPTA37@GMAIL.COM", "AQAAAAIAAYagAAAAEI3Xm1MVsk6hT6ZSYBUiu5EVuz/mwRdx/o183bDYm0YDXid+FRxY9zI/K9Rp/q6VWw==", null, "123-456-7890", false, null, "9fd43c6a-cf96-448a-8516-be8fcecb9581", "New Delhi", false, "arpit.gupta37@gmail.com" },
                    { "38", 0, null, "O-", "Noida", "72f11190-0c81-4fc6-b4de-5980785352f0", "India", "ApplicationUser", "yash.prakash38@gmail.com", true, "Yash Prakash", false, null, "YASH.PRAKASH38@GMAIL.COM", "YASH.PRAKASH38@GMAIL.COM", "AQAAAAIAAYagAAAAECnzrfUhzS8CKRHCLQFMF3KdXtx/KVfcJKrAgmEOXjsjxqkJUgWHIUKX9q22jaBrig==", null, "123-456-7890", false, null, "89e23a29-aa3c-453b-974f-79def739a85b", "Mumbai", false, "yash.prakash38@gmail.com" },
                    { "39", 0, null, "AB+", "Faridabad", "9b6c5f89-07dd-4229-8203-7191bc219924", "India", "ApplicationUser", "vinay.aggarwal39@gmail.com", true, "Vinay Aggarwal", false, null, "VINAY.AGGARWAL39@GMAIL.COM", "VINAY.AGGARWAL39@GMAIL.COM", "AQAAAAIAAYagAAAAEPKs6qXbPUG3tRz9wc4Y3hKvHcpxStG6nqL40/7PAZW3nYgomEzcbAeliDo61xdoNQ==", null, "123-456-7890", false, null, "cb9eab3d-65a6-4c96-bfe0-e21501bd8164", "Chandigarh", false, "vinay.aggarwal39@gmail.com" },
                    { "4", 0, null, "B-", "Shahdara", "f1910a1f-3d6e-4885-be45-95e391f15abc", "India", "ApplicationUser", "yash.sharma4@gmail.com", true, "Yash Sharma", false, null, "YASH.SHARMA4@GMAIL.COM", "YASH.SHARMA4@GMAIL.COM", "AQAAAAIAAYagAAAAECEs787Gfv3/aVM6A63vE+9EW5/wBy5PGKpuqXhIilmLgEh+RyRHRQsmOLPHXJSKOQ==", null, "123-456-7890", false, null, "a75b2c3b-eb49-4bf0-8afa-c27d945b86ed", "Banglore", false, "yash.sharma4@gmail.com" },
                    { "40", 0, null, "AB-", "Shahdara", "2bf7eb1a-2367-460b-8b80-a293f92ca467", "India", "ApplicationUser", "ritik.singh40@gmail.com", true, "Ritik Singh", false, null, "RITIK.SINGH40@GMAIL.COM", "RITIK.SINGH40@GMAIL.COM", "AQAAAAIAAYagAAAAENttJVKWAfwFaO2vgpaz+TYnzdffutQa2rJsYscRn06+23C/TwoBGMzRDISOR9imFA==", null, "123-456-7890", false, null, "fc37cc0a-d1de-4a63-829a-20cdc9eb1078", "Banglore", false, "ritik.singh40@gmail.com" },
                    { "41", 0, null, "A+", "Rohini", "c145bff4-fc4b-4d44-961d-619cb578a722", "India", "ApplicationUser", "jatin.bansal41@gmail.com", true, "Jatin Bansal", false, null, "JATIN.BANSAL41@GMAIL.COM", "JATIN.BANSAL41@GMAIL.COM", "AQAAAAIAAYagAAAAEKm0wSCQz/uvq7PFDmAG8x7ktj5QbvKqi1krqTKB5ezm1C7PXVbFwq7hlUtWJMHz+g==", null, "123-456-7890", false, null, "a65f959b-a29a-4261-ae9f-3dc9c52a2b95", "U.P", false, "jatin.bansal41@gmail.com" },
                    { "42", 0, null, "A-", "Patel Nagar", "6d44f9aa-5295-4ac3-b58e-1be8bdec6767", "India", "ApplicationUser", "sneha.jain42@gmail.com", true, "Sneha Jain", false, null, "SNEHA.JAIN42@GMAIL.COM", "SNEHA.JAIN42@GMAIL.COM", "AQAAAAIAAYagAAAAEL3e1ZdNoChPkQgE600nW/qNTFTTxI2LSQKPR/6bw6bo0+QbznwsK4eAmhqIsN5iuA==", null, "123-456-7890", false, null, "3b23513f-cad8-4a54-aff2-72a63521aec8", "Haryana", false, "sneha.jain42@gmail.com" },
                    { "43", 0, null, "B+", "Dwarka", "d52087f7-d4be-4654-80a2-eb6d369a06a1", "India", "ApplicationUser", "monika.goyal43@gmail.com", true, "Monika Goyal", false, null, "MONIKA.GOYAL43@GMAIL.COM", "MONIKA.GOYAL43@GMAIL.COM", "AQAAAAIAAYagAAAAEIRekelUBVC9Jx19A+8h9jzQMm0xMY4gS70GPmJGuISwzUavxPKtYi8z+46Zh0HYEw==", null, "123-456-7890", false, null, "b139e434-8f8f-48c5-b995-c687f624821b", "New Delhi", false, "monika.goyal43@gmail.com" },
                    { "44", 0, null, "B-", "Azadnagar", "dbf5f649-bd28-492e-afbd-b10787c94fd7", "India", "ApplicationUser", "tanisha.sharma44@gmail.com", true, "Tanisha Sharma", false, null, "TANISHA.SHARMA44@GMAIL.COM", "TANISHA.SHARMA44@GMAIL.COM", "AQAAAAIAAYagAAAAEMpQQNuoZYBd0bHsm7FbyZzBEmcLKcRhr0oY3U0cqCCJlK9sgXccxcNHp37I++bAbQ==", null, "123-456-7890", false, null, "1e4e976d-1b12-4325-aa43-8bece296dfaa", "Mumbai", false, "tanisha.sharma44@gmail.com" },
                    { "45", 0, null, "O+", "Krishna Nagar", "b168b4a5-5380-40b2-af0c-d2430fcb110e", "India", "ApplicationUser", "manya.gupta45@gmail.com", true, "Manya Gupta", false, null, "MANYA.GUPTA45@GMAIL.COM", "MANYA.GUPTA45@GMAIL.COM", "AQAAAAIAAYagAAAAEMBo7D7kI+YRx+uFk4M2Mg+EU0+yhw7Mv3AivDYhlAadwzlOBSDSOW675ua1FJYGcA==", null, "123-456-7890", false, null, "49ae8193-a2c6-4672-87a7-460b5897b04e", "Chandigarh", false, "manya.gupta45@gmail.com" },
                    { "46", 0, null, "O-", "Gaziabad", "95557239-b821-444f-80e8-302c4be6714a", "India", "ApplicationUser", "khushi.prakash46@gmail.com", true, "Khushi Prakash", false, null, "KHUSHI.PRAKASH46@GMAIL.COM", "KHUSHI.PRAKASH46@GMAIL.COM", "AQAAAAIAAYagAAAAEJJpemglC34LBoxpHY+86BKgtAMjip2U+mXHCjp3oQmRHrqJcBiO+5/wwnyCPnb0PA==", null, "123-456-7890", false, null, "34c364ad-1163-41b5-9878-305d2bf15ee2", "Banglore", false, "khushi.prakash46@gmail.com" },
                    { "47", 0, null, "AB+", "Noida", "47dc23f5-d8af-460d-9c2a-c53dd7f0df95", "India", "ApplicationUser", "kritika.aggarwal47@gmail.com", true, "Kritika Aggarwal", false, null, "KRITIKA.AGGARWAL47@GMAIL.COM", "KRITIKA.AGGARWAL47@GMAIL.COM", "AQAAAAIAAYagAAAAEOVuv/y8APItaUpWUtXssBRNMi4t46DhQRYFZgD66SN9ZmISbZrcjT2A47B17aSjbQ==", null, "123-456-7890", false, null, "e7ee9fbb-ef0f-4a60-b0fb-26302eccd047", "U.P", false, "kritika.aggarwal47@gmail.com" },
                    { "48", 0, null, "AB-", "Faridabad", "153f1f27-8a79-4e7d-a1c6-1032ba4ba953", "India", "ApplicationUser", "preeti.singh48@gmail.com", true, "Preeti Singh", false, null, "PREETI.SINGH48@GMAIL.COM", "PREETI.SINGH48@GMAIL.COM", "AQAAAAIAAYagAAAAEAon3r0GxcjeX0whq3FyQhZAeFpgUGKXtghCBtCX5Ku33YfzV5wZJnUHEutRwph1SA==", null, "123-456-7890", false, null, "4d6b9991-8362-4294-afd2-5d064e807f2b", "Haryana", false, "preeti.singh48@gmail.com" },
                    { "49", 0, null, "A+", "Shahdara", "308617a5-bf44-48da-a6e9-8383a67d4797", "India", "ApplicationUser", "nisha.bansal49@gmail.com", true, "Nisha Bansal", false, null, "NISHA.BANSAL49@GMAIL.COM", "NISHA.BANSAL49@GMAIL.COM", "AQAAAAIAAYagAAAAEDhzy9RHY+blq4vmwy+JPyrm/tJ0oY/Vn8FrjVudBcNXRjNTiYFLv2T12p7byNxoyA==", null, "123-456-7890", false, null, "1b199fb6-737b-4b47-b9cc-86b99e5252e3", "New Delhi", false, "nisha.bansal49@gmail.com" },
                    { "5", 0, null, "O+", "Rohini", "3a3ea999-05bb-42ac-8c61-a7aed74af738", "India", "ApplicationUser", "vinay.gupta5@gmail.com", true, "Vinay Gupta", false, null, "VINAY.GUPTA5@GMAIL.COM", "VINAY.GUPTA5@GMAIL.COM", "AQAAAAIAAYagAAAAEBbYx2Cme5FjMXUJNo8e+xq9aZv3sJwiahsptyr47BC1S80WH1QGvvdh+Fqur6eK0g==", null, "123-456-7890", false, null, "5f4c3b9a-25f6-43d9-8dd7-c282446fb562", "U.P", false, "vinay.gupta5@gmail.com" },
                    { "50", 0, null, "A-", "Rohini", "f43f8826-4e6f-4c41-b77b-cc06e2b32d4b", "India", "ApplicationUser", "dhruv.jain50@gmail.com", true, "Dhruv Jain", false, null, "DHRUV.JAIN50@GMAIL.COM", "DHRUV.JAIN50@GMAIL.COM", "AQAAAAIAAYagAAAAEFk7fiHRtZiKmHLVkBkifBcSZzy4yU2jVhY52gESybiqvVsAeSGUgcfFkF7j/xHxxg==", null, "123-456-7890", false, null, "2493fdd3-31de-4fa6-86cc-3e8402ca2be8", "Mumbai", false, "dhruv.jain50@gmail.com" },
                    { "51", 0, null, "B+", "Patel Nagar", "8b3f75a5-db0f-4e59-b42c-43b677c7ee50", "India", "ApplicationUser", "shubham.goyal51@gmail.com", true, "Shubham Goyal", false, null, "SHUBHAM.GOYAL51@GMAIL.COM", "SHUBHAM.GOYAL51@GMAIL.COM", "AQAAAAIAAYagAAAAEEi2X8RfS+3Y0yngDK5O34SGqeWhT0jkyAtfmkA2sq59cTvdg6wUuHkWgcZ2VXZsUQ==", null, "123-456-7890", false, null, "cce0f17b-5bba-47a6-b2c5-da3b9399bed4", "Chandigarh", false, "shubham.goyal51@gmail.com" },
                    { "52", 0, null, "B-", "Dwarka", "68a5d497-1c8d-4307-954f-7ccc0ae7f535", "India", "ApplicationUser", "rohit.sharma52@gmail.com", true, "Rohit Sharma", false, null, "ROHIT.SHARMA52@GMAIL.COM", "ROHIT.SHARMA52@GMAIL.COM", "AQAAAAIAAYagAAAAEICC1RzhcMeLMWSQCuUXVnd1XOcEHKD+BDwzN3XhQCRWkXd+Eg8sZqnqzUkRShlkgg==", null, "123-456-7890", false, null, "646ee2c0-abca-4925-b376-3a93c9e702e0", "Banglore", false, "rohit.sharma52@gmail.com" },
                    { "53", 0, null, "O+", "Azadnagar", "f4a5ccfd-b23c-4da1-a06d-a277ede64aeb", "India", "ApplicationUser", "kunal.gupta53@gmail.com", true, "Kunal Gupta", false, null, "KUNAL.GUPTA53@GMAIL.COM", "KUNAL.GUPTA53@GMAIL.COM", "AQAAAAIAAYagAAAAENiH43XN7xM38KRqelo8PvpTFobtJ6MfulrEEEjDPlRIDvV4JJsDRhxSXbGmSrgkOQ==", null, "123-456-7890", false, null, "31fce5eb-fc42-4e0e-9673-7774aa018f4a", "U.P", false, "kunal.gupta53@gmail.com" },
                    { "54", 0, null, "O-", "Krishna Nagar", "038bef41-3721-4515-b598-97b13f882917", "India", "ApplicationUser", "arpit.prakash54@gmail.com", true, "Arpit Prakash", false, null, "ARPIT.PRAKASH54@GMAIL.COM", "ARPIT.PRAKASH54@GMAIL.COM", "AQAAAAIAAYagAAAAEMRfEz6Jn4oUCxRMRgz42zZ5qbDBe6gxu6hS9JYeFMeupn1R8+W0gxFs+yjV7UuBhQ==", null, "123-456-7890", false, null, "76617bff-80b8-44ca-8617-6be6ec5d604f", "Haryana", false, "arpit.prakash54@gmail.com" },
                    { "55", 0, null, "AB+", "Gaziabad", "c213a81a-1597-4175-b377-df48efd9b414", "India", "ApplicationUser", "yash.aggarwal55@gmail.com", true, "Yash Aggarwal", false, null, "YASH.AGGARWAL55@GMAIL.COM", "YASH.AGGARWAL55@GMAIL.COM", "AQAAAAIAAYagAAAAEMxukrvIVP/sgGiBtXiQVAmAI35+pZ17pnDAwWVxTwQHWBNs4rtgxX38v/RJ/fMHhA==", null, "123-456-7890", false, null, "871a0f83-1f60-46e8-807a-4a997cbb4240", "New Delhi", false, "yash.aggarwal55@gmail.com" },
                    { "56", 0, null, "AB-", "Noida", "e6ec49d2-94ce-4a37-9fd2-29764e5e3e86", "India", "ApplicationUser", "vinay.singh56@gmail.com", true, "Vinay Singh", false, null, "VINAY.SINGH56@GMAIL.COM", "VINAY.SINGH56@GMAIL.COM", "AQAAAAIAAYagAAAAEPoH4Ma66tw+Ivm5z96fv/Y17V3CpXQFwp4SAJw9Z5LBOdbndKJCqpl32VUJjKgX7Q==", null, "123-456-7890", false, null, "f1293cfb-fb19-4ee8-8781-0e13aa6fdb70", "Mumbai", false, "vinay.singh56@gmail.com" },
                    { "57", 0, null, "A+", "Faridabad", "2c8f9fdf-ff11-4d83-97bc-8d90e1287b61", "India", "ApplicationUser", "ritik.bansal57@gmail.com", true, "Ritik Bansal", false, null, "RITIK.BANSAL57@GMAIL.COM", "RITIK.BANSAL57@GMAIL.COM", "AQAAAAIAAYagAAAAEFGjb/pYrTqNX+DXFbGXgDEpjIDTaChCLdgyxzO1KmAQv2XdRsxSIvw2WrvX4eOY6g==", null, "123-456-7890", false, null, "3764b4c4-3714-49a0-a95d-11daf6ddaa39", "Chandigarh", false, "ritik.bansal57@gmail.com" },
                    { "58", 0, null, "A-", "Shahdara", "2fc7811d-bf91-4529-af10-74260e020073", "India", "ApplicationUser", "jatin.jain58@gmail.com", true, "Jatin Jain", false, null, "JATIN.JAIN58@GMAIL.COM", "JATIN.JAIN58@GMAIL.COM", "AQAAAAIAAYagAAAAEHpIxDpbViIz1KXUFJrktrV4MH3J7kct3JN+R5HmzQR1yCGDeVTVFBc64sO2KrtdpQ==", null, "123-456-7890", false, null, "e3c5f69f-81cf-47d4-8ee3-042347a97e5f", "Banglore", false, "jatin.jain58@gmail.com" },
                    { "59", 0, null, "B+", "Rohini", "90ae05e8-3a1d-4743-9f5d-a14d549aa19f", "India", "ApplicationUser", "sneha.goyal59@gmail.com", true, "Sneha Goyal", false, null, "SNEHA.GOYAL59@GMAIL.COM", "SNEHA.GOYAL59@GMAIL.COM", "AQAAAAIAAYagAAAAEK6FBV6IRPznlgyPYU4gVDY9zRivjKcw+ZRjJA390BltbYiI58JgGYvF5/+KNgFS2Q==", null, "123-456-7890", false, null, "9a8f490f-5187-4dbe-8c37-b6c9342697d9", "U.P", false, "sneha.goyal59@gmail.com" },
                    { "6", 0, null, "O-", "Patel Nagar", "01de0d97-6271-4770-9cf9-69c3cc367a41", "India", "ApplicationUser", "ritik.prakash6@gmail.com", true, "Ritik Prakash", false, null, "RITIK.PRAKASH6@GMAIL.COM", "RITIK.PRAKASH6@GMAIL.COM", "AQAAAAIAAYagAAAAEM6Oyx7bnPMr/pOaaF9uuIZruHn00ehODoNm8uAkfgesKgIVTuDv9XV+J/uNlVskQw==", null, "123-456-7890", false, null, "3d584f49-e6c7-41cc-ac2e-8491a46586a4", "Haryana", false, "ritik.prakash6@gmail.com" },
                    { "60", 0, null, "B-", "Patel Nagar", "a9efac4e-81a0-46f0-be18-36b0a53d7f35", "India", "ApplicationUser", "monika.sharma60@gmail.com", true, "Monika Sharma", false, null, "MONIKA.SHARMA60@GMAIL.COM", "MONIKA.SHARMA60@GMAIL.COM", "AQAAAAIAAYagAAAAEIpfsX59pu69IfhPppvqbVhg3VoBdZmfHu/MwMO5JGNm3pPByE2QpyR8PjwHlqnVsw==", null, "123-456-7890", false, null, "4e4a008b-0842-4407-9aaa-81b5aed6ab38", "Haryana", false, "monika.sharma60@gmail.com" },
                    { "61", 0, null, "O+", "Dwarka", "1271359e-1b92-4abd-9006-3f5d48224845", "India", "ApplicationUser", "tanisha.gupta61@gmail.com", true, "Tanisha Gupta", false, null, "TANISHA.GUPTA61@GMAIL.COM", "TANISHA.GUPTA61@GMAIL.COM", "AQAAAAIAAYagAAAAEKSDtJTPYCIB/ODZYVfzn1qLlXAku03XFJzwUaHSVbdirAKe1XOq+en3DMaW09LMJg==", null, "123-456-7890", false, null, "29c82a50-d7f9-4d22-8d1f-d05682122ecc", "New Delhi", false, "tanisha.gupta61@gmail.com" },
                    { "62", 0, null, "O-", "Azadnagar", "c43391e1-7d20-435a-b98d-5f1c27e5d554", "India", "ApplicationUser", "manya.prakash62@gmail.com", true, "Manya Prakash", false, null, "MANYA.PRAKASH62@GMAIL.COM", "MANYA.PRAKASH62@GMAIL.COM", "AQAAAAIAAYagAAAAEFGzxuHDAioDZPCVPUxDH/43AOlZ2HI3aapMUIp8W6MLSPWhE3W8g23U+tbZSADyUA==", null, "123-456-7890", false, null, "3a5105a8-2d8a-42ff-a378-31688755de36", "Mumbai", false, "manya.prakash62@gmail.com" },
                    { "63", 0, null, "AB+", "Krishna Nagar", "804d38c2-ea7b-4e7e-9a2f-fcf701430269", "India", "ApplicationUser", "khushi.aggarwal63@gmail.com", true, "Khushi Aggarwal", false, null, "KHUSHI.AGGARWAL63@GMAIL.COM", "KHUSHI.AGGARWAL63@GMAIL.COM", "AQAAAAIAAYagAAAAECg16o/QruX0+6wMAguA9KsDtaaQzbwsiDGuoJt6BiiM0Zclyi6pVYpOiTSK8bICzg==", null, "123-456-7890", false, null, "cc317176-8b1a-4389-b06f-d807db994574", "Chandigarh", false, "khushi.aggarwal63@gmail.com" },
                    { "64", 0, null, "AB-", "Gaziabad", "fab3555f-1d86-4bed-a75d-97dffdfe09e5", "India", "ApplicationUser", "kritika.singh64@gmail.com", true, "Kritika Singh", false, null, "KRITIKA.SINGH64@GMAIL.COM", "KRITIKA.SINGH64@GMAIL.COM", "AQAAAAIAAYagAAAAEHk6+TSzR+9/CAv8WIjxDxeg+UPufeJUTX16G7PfknONMJ2bxVB16yzeyoWO//8VUA==", null, "123-456-7890", false, null, "a2162188-f984-4a11-b861-c1e231b742cf", "Banglore", false, "kritika.singh64@gmail.com" },
                    { "65", 0, null, "A+", "Noida", "322d9663-8ec0-44cb-b238-3c05113b21d5", "India", "ApplicationUser", "preeti.bansal65@gmail.com", true, "Preeti Bansal", false, null, "PREETI.BANSAL65@GMAIL.COM", "PREETI.BANSAL65@GMAIL.COM", "AQAAAAIAAYagAAAAEHNx/3nnPngfQbUBSdTUDBEw6ZZBQ3eaK2h5zxNKUCDPPbYW3X9+EojVBD46gZuOQg==", null, "123-456-7890", false, null, "ff919d41-5fce-434d-a1c9-32398a3126a7", "U.P", false, "preeti.bansal65@gmail.com" },
                    { "66", 0, null, "A-", "Faridabad", "42b51bf8-00be-42ed-a865-16d6c41503d6", "India", "ApplicationUser", "nisha.jain66@gmail.com", true, "Nisha Jain", false, null, "NISHA.JAIN66@GMAIL.COM", "NISHA.JAIN66@GMAIL.COM", "AQAAAAIAAYagAAAAEOLSBCbqNknRi80LNJ8Owm6u9sEfUo9N9gPjV7PM/JTv+T4Q0RY0969yhHLKNc6sIA==", null, "123-456-7890", false, null, "1f49388c-da43-4f07-9ae6-c36ae1d9a457", "Haryana", false, "nisha.jain66@gmail.com" },
                    { "67", 0, null, "B+", "Shahdara", "b0a86415-7cd6-4607-9f96-bad9dfb0cc86", "India", "ApplicationUser", "dhruv.goyal67@gmail.com", true, "Dhruv Goyal", false, null, "DHRUV.GOYAL67@GMAIL.COM", "DHRUV.GOYAL67@GMAIL.COM", "AQAAAAIAAYagAAAAECzky8kwpZe0IY9Lk6x58Io66JDJVFoh+phlFGlFwZ8WRBETp/Fi8YlHzFPMupUKEg==", null, "123-456-7890", false, null, "8fa076d7-c2e6-4f18-ab76-5339427616c6", "New Delhi", false, "dhruv.goyal67@gmail.com" },
                    { "68", 0, null, "B-", "Rohini", "30d4b163-dc8f-45a2-9564-d3c8ff52dd23", "India", "ApplicationUser", "shubham.sharma68@gmail.com", true, "Shubham Sharma", false, null, "SHUBHAM.SHARMA68@GMAIL.COM", "SHUBHAM.SHARMA68@GMAIL.COM", "AQAAAAIAAYagAAAAECceD0GyWxzuIsEyH5c8zDrFJTxMvEllVl1YQuiPuJyQ3R3rg3GasmAFWVWZocmQWQ==", null, "123-456-7890", false, null, "77185011-ff96-485d-b85b-69186f5e4075", "Mumbai", false, "shubham.sharma68@gmail.com" },
                    { "69", 0, null, "O+", "Patel Nagar", "5dec16c8-7df5-42d6-94e4-91cc9d245ba0", "India", "ApplicationUser", "rohit.gupta69@gmail.com", true, "Rohit Gupta", false, null, "ROHIT.GUPTA69@GMAIL.COM", "ROHIT.GUPTA69@GMAIL.COM", "AQAAAAIAAYagAAAAEJCqgpDqI2lMlSiMBpdppYWWkaoTxnLQN8aB/4iWkfRwd49Cjqri0Hxik+10Gykp+Q==", null, "123-456-7890", false, null, "173435fc-c0a9-46df-b46d-6a115ca66c7e", "Chandigarh", false, "rohit.gupta69@gmail.com" },
                    { "7", 0, null, "AB+", "Dwarka", "eaa0f73b-fed5-4109-a999-96da3becd4cc", "India", "ApplicationUser", "jatin.aggarwal7@gmail.com", true, "Jatin Aggarwal", false, null, "JATIN.AGGARWAL7@GMAIL.COM", "JATIN.AGGARWAL7@GMAIL.COM", "AQAAAAIAAYagAAAAEF9UhXlh0rWBkoQnleKXVXi6AHu/a3EZiwg7si0XJDViLykr2rED6+oZA4iyXTN6ng==", null, "123-456-7890", false, null, "00b89f36-3def-42a5-9124-10a484a4d086", "New Delhi", false, "jatin.aggarwal7@gmail.com" },
                    { "70", 0, null, "O-", "Dwarka", "9f23763c-0e9a-4cef-b563-a91142bf4710", "India", "ApplicationUser", "kunal.prakash70@gmail.com", true, "Kunal Prakash", false, null, "KUNAL.PRAKASH70@GMAIL.COM", "KUNAL.PRAKASH70@GMAIL.COM", "AQAAAAIAAYagAAAAEG0LfqlijnC9JMvcAVWemH3fg8s+tqOcbm9W80xWdC0wMPpZvHJOmd1+RQihMvSc/w==", null, "123-456-7890", false, null, "f4d16198-b70b-434e-9843-54ef8b0d4157", "Banglore", false, "kunal.prakash70@gmail.com" },
                    { "71", 0, null, "AB+", "Azadnagar", "3e7dbe2b-f9c4-48cd-8725-e72d16b23419", "India", "ApplicationUser", "arpit.aggarwal71@gmail.com", true, "Arpit Aggarwal", false, null, "ARPIT.AGGARWAL71@GMAIL.COM", "ARPIT.AGGARWAL71@GMAIL.COM", "AQAAAAIAAYagAAAAEE6i/xhvc7YhX14/1sNgSoSHM+MW/S3B1E6MS9SnH8su7xCl35IfEA+cXqIu0kffbw==", null, "123-456-7890", false, null, "c09418d8-a242-4e1b-bcee-5ba1bc10d753", "U.P", false, "arpit.aggarwal71@gmail.com" },
                    { "72", 0, null, "AB-", "Krishna Nagar", "9dbe7364-2d98-457b-a0ed-4a1daaba7a68", "India", "ApplicationUser", "yash.singh72@gmail.com", true, "Yash Singh", false, null, "YASH.SINGH72@GMAIL.COM", "YASH.SINGH72@GMAIL.COM", "AQAAAAIAAYagAAAAECNX14zLmF2UZZMth1/nbBNNRK51tPc6s5+r29ilRkRHYGm7F0YKqspAwj+XhO+d6w==", null, "123-456-7890", false, null, "8bb8dbe6-4929-49ad-8fbf-537847546f51", "Haryana", false, "yash.singh72@gmail.com" },
                    { "73", 0, null, "A+", "Gaziabad", "0d380ad1-3637-4849-817a-0894ae367cc6", "India", "ApplicationUser", "vinay.bansal73@gmail.com", true, "Vinay Bansal", false, null, "VINAY.BANSAL73@GMAIL.COM", "VINAY.BANSAL73@GMAIL.COM", "AQAAAAIAAYagAAAAEITdA5nHSGCLZLsnksgak4U5bzh0eCoUYyjUjFsrxjjclJovGN0vAEyP/KCu4VN5Hg==", null, "123-456-7890", false, null, "0ea0af88-4732-4eef-99cb-6a3db3eb4c21", "New Delhi", false, "vinay.bansal73@gmail.com" },
                    { "74", 0, null, "A-", "Noida", "ceac29c8-d9cc-4243-a4c6-3e090e2716db", "India", "ApplicationUser", "ritik.jain74@gmail.com", true, "Ritik Jain", false, null, "RITIK.JAIN74@GMAIL.COM", "RITIK.JAIN74@GMAIL.COM", "AQAAAAIAAYagAAAAECHMvV81OhQT32QVt0362H3fBoE8sm7zTUucvwa5sXaZlQWSijs+5dw7OpN0dkrFhg==", null, "123-456-7890", false, null, "dbf23f87-601c-4a57-98fc-51ceaf31ac0d", "Mumbai", false, "ritik.jain74@gmail.com" },
                    { "75", 0, null, "B+", "Faridabad", "4d0b5e58-c279-49ff-9470-d35e66276f52", "India", "ApplicationUser", "jatin.goyal75@gmail.com", true, "Jatin Goyal", false, null, "JATIN.GOYAL75@GMAIL.COM", "JATIN.GOYAL75@GMAIL.COM", "AQAAAAIAAYagAAAAEFrU0B41nP1V9F6hYxcyfozipCkN774s5/mhNpble535RUeQIS22guNccPS1m16zeg==", null, "123-456-7890", false, null, "3cba3645-50aa-45e3-b735-972b9eb0cbaf", "Chandigarh", false, "jatin.goyal75@gmail.com" },
                    { "76", 0, null, "B-", "Shahdara", "494668d2-bdb8-426d-a2f1-e30e6abfd966", "India", "ApplicationUser", "sneha.sharma76@gmail.com", true, "Sneha Sharma", false, null, "SNEHA.SHARMA76@GMAIL.COM", "SNEHA.SHARMA76@GMAIL.COM", "AQAAAAIAAYagAAAAEBPtJrYVr+bfadYhroHZMzzFMPZZxVBSLpw3+E1fZ8PoLfKcm6yBkSxhNcpn3EgqTw==", null, "123-456-7890", false, null, "267ca2a3-1bfd-4ac6-8c6b-e46420623d4f", "Banglore", false, "sneha.sharma76@gmail.com" },
                    { "77", 0, null, "O+", "Rohini", "a22be7f2-3858-4dd7-9fc1-6a011db165e3", "India", "ApplicationUser", "monika.gupta77@gmail.com", true, "Monika Gupta", false, null, "MONIKA.GUPTA77@GMAIL.COM", "MONIKA.GUPTA77@GMAIL.COM", "AQAAAAIAAYagAAAAEODkey9fGq8k2rmvdUbElW6JbNeIAh4RZbGZK6jOkdv1V15oHxLXiFUiBIfIcLJgcg==", null, "123-456-7890", false, null, "b7ea781e-188c-4773-95ef-50cae284a781", "U.P", false, "monika.gupta77@gmail.com" },
                    { "78", 0, null, "O-", "Patel Nagar", "b21c790a-5fc5-452f-8d21-2c3ee868d0ed", "India", "ApplicationUser", "tanisha.prakash78@gmail.com", true, "Tanisha Prakash", false, null, "TANISHA.PRAKASH78@GMAIL.COM", "TANISHA.PRAKASH78@GMAIL.COM", "AQAAAAIAAYagAAAAEIYRFmxmGSNUdIqfza+bLzJD69sbWokRs2RdsY9DG+3ax6wp94ZkFBVWxH8/1pTyIQ==", null, "123-456-7890", false, null, "695056b1-9c88-4044-b7c4-1579a9973ba5", "Haryana", false, "tanisha.prakash78@gmail.com" },
                    { "79", 0, null, "AB+", "Dwarka", "f2d0febd-6828-4a1b-a216-d8d7ad5b6c2f", "India", "ApplicationUser", "manya.aggarwal79@gmail.com", true, "Manya Aggarwal", false, null, "MANYA.AGGARWAL79@GMAIL.COM", "MANYA.AGGARWAL79@GMAIL.COM", "AQAAAAIAAYagAAAAEO8v+/0VLaO3dd9ABAvRp9WAEA6NhrV4H/WnhvqCeVpWniJGS/JR2XJzk1v8t5yLZA==", null, "123-456-7890", false, null, "7bb5fb3c-d169-4443-83a1-96712ee665c1", "New Delhi", false, "manya.aggarwal79@gmail.com" },
                    { "8", 0, null, "AB-", "Azadnagar", "bd35f5c7-b792-40cc-8de1-ed54082f495d", "India", "ApplicationUser", "sneha.singh8@gmail.com", true, "Sneha Singh", false, null, "SNEHA.SINGH8@GMAIL.COM", "SNEHA.SINGH8@GMAIL.COM", "AQAAAAIAAYagAAAAEB8YlX/l6lCIqxM9zPfD6l2RPsLKbGXN9AqhexF9sGcoGinBFgbjCiJkyfYp+zLZQA==", null, "123-456-7890", false, null, "60813ecc-4a39-4728-b035-7ed06ea732d1", "Mumbai", false, "sneha.singh8@gmail.com" },
                    { "80", 0, null, "AB-", "Azadnagar", "0cb8d35b-f862-437d-ba8f-73e3462e3233", "India", "ApplicationUser", "khushi.singh80@gmail.com", true, "Khushi Singh", false, null, "KHUSHI.SINGH80@GMAIL.COM", "KHUSHI.SINGH80@GMAIL.COM", "AQAAAAIAAYagAAAAEMyOQY8zx4bCh2xomXtDjjG8MVXha2Yz1wfo3XLStIS6Ge+jk2TRJqMacVfkvbDPsw==", null, "123-456-7890", false, null, "1d881f19-433c-4617-ba19-be7a6a7d5a71", "Mumbai", false, "khushi.singh80@gmail.com" },
                    { "81", 0, null, "A+", "Krishna Nagar", "0d9b37c4-f9e4-4f6d-badc-342a0a5780dd", "India", "ApplicationUser", "kritika.bansal81@gmail.com", true, "Kritika Bansal", false, null, "KRITIKA.BANSAL81@GMAIL.COM", "KRITIKA.BANSAL81@GMAIL.COM", "AQAAAAIAAYagAAAAEBT/QvFxLQEWoY9KYijkWbnlrNdFVO5az8mMd0oB9B7yQTDSWeTAHJqe0idnoPJYIw==", null, "123-456-7890", false, null, "ee1975cf-a6ff-4032-9cde-304bf1010acc", "Chandigarh", false, "kritika.bansal81@gmail.com" },
                    { "82", 0, null, "A-", "Gaziabad", "fa0d1a3f-6b96-44f8-b0a3-1ec0905f94e2", "India", "ApplicationUser", "preeti.jain82@gmail.com", true, "Preeti Jain", false, null, "PREETI.JAIN82@GMAIL.COM", "PREETI.JAIN82@GMAIL.COM", "AQAAAAIAAYagAAAAEMh0ObZJb9/5hIItcUAmNsIb9iaXZlBc3belzp8JpjP0+Pgcd9hrDKmZKQuBPzIqaQ==", null, "123-456-7890", false, null, "57e48bdd-59dd-4e3d-b007-9bc092756fc5", "Banglore", false, "preeti.jain82@gmail.com" },
                    { "83", 0, null, "B+", "Noida", "6fb35a28-e0ae-490a-a188-3455c53ad637", "India", "ApplicationUser", "nisha.goyal83@gmail.com", true, "Nisha Goyal", false, null, "NISHA.GOYAL83@GMAIL.COM", "NISHA.GOYAL83@GMAIL.COM", "AQAAAAIAAYagAAAAEJue7vCSTLwdI2nO8F4h4tfSbqpuBDDsTZf92MwNnoGhHrzsX9GegRN4J+b1p0BX0w==", null, "123-456-7890", false, null, "5b8b662a-3526-45d1-8fe6-2a56ee23573f", "U.P", false, "nisha.goyal83@gmail.com" },
                    { "84", 0, null, "B-", "Faridabad", "d3c27269-3f29-47d4-ba5b-00478c0d5740", "India", "ApplicationUser", "dhruv.sharma84@gmail.com", true, "Dhruv Sharma", false, null, "DHRUV.SHARMA84@GMAIL.COM", "DHRUV.SHARMA84@GMAIL.COM", "AQAAAAIAAYagAAAAEOkSAS8F/nZ8HRoWQuR2sOn372lAdGJCEPHQvFX8oTGeKa4189bpH6iUUJVPcyyAJw==", null, "123-456-7890", false, null, "20b65c5c-f4ec-44d4-afd4-9f2b4501248f", "Haryana", false, "dhruv.sharma84@gmail.com" },
                    { "85", 0, null, "O+", "Shahdara", "f7693b7e-3ef2-4521-be06-304b7beeb74d", "India", "ApplicationUser", "shubham.gupta85@gmail.com", true, "Shubham Gupta", false, null, "SHUBHAM.GUPTA85@GMAIL.COM", "SHUBHAM.GUPTA85@GMAIL.COM", "AQAAAAIAAYagAAAAEMWHjkilBOvYJEMd7o3QfivTaLISzYqa+4zF4jKeknQgEwoGblnl1SdHN8dKGEfZcA==", null, "123-456-7890", false, null, "56ac9f03-998e-4a8c-8bae-d2ec0c2ccefc", "New Delhi", false, "shubham.gupta85@gmail.com" },
                    { "86", 0, null, "O-", "Rohini", "e845efee-0b65-4991-a189-cb478c820c3d", "India", "ApplicationUser", "rohit.prakash86@gmail.com", true, "Rohit Prakash", false, null, "ROHIT.PRAKASH86@GMAIL.COM", "ROHIT.PRAKASH86@GMAIL.COM", "AQAAAAIAAYagAAAAEK7JZ+gyp7ERbmP7CgRLDEs+SnzHyCH8xhJAul1aKoXqLtYiQ4fsH9ojmpd/DtLm4w==", null, "123-456-7890", false, null, "2f9acefb-ab38-40db-8bfe-6e796a780d35", "Mumbai", false, "rohit.prakash86@gmail.com" },
                    { "87", 0, null, "AB+", "Patel Nagar", "ad9a7980-df7c-48d3-9097-bac5af934b2c", "India", "ApplicationUser", "kunal.aggarwal87@gmail.com", true, "Kunal Aggarwal", false, null, "KUNAL.AGGARWAL87@GMAIL.COM", "KUNAL.AGGARWAL87@GMAIL.COM", "AQAAAAIAAYagAAAAEAkoSQrvuGtYDe0+0FPCVprtB+fGAPS2OL5af+mSIuPOAWMZ/RXJbEUD+nzw5mRZ4Q==", null, "123-456-7890", false, null, "4187175d-c27b-4668-b155-66eb2bd82c05", "Chandigarh", false, "kunal.aggarwal87@gmail.com" },
                    { "88", 0, null, "AB-", "Dwarka", "97cdd742-375d-4ec5-bc75-173645225bd6", "India", "ApplicationUser", "arpit.singh88@gmail.com", true, "Arpit Singh", false, null, "ARPIT.SINGH88@GMAIL.COM", "ARPIT.SINGH88@GMAIL.COM", "AQAAAAIAAYagAAAAECj8/jRa9sQ+pldmedecky4LVou8Gke7LjSJHVlgVBFwS0y4Fy8qiQidgY4kvGxGqA==", null, "123-456-7890", false, null, "b598bee9-5e5b-4261-9ee7-80537c6567aa", "Banglore", false, "arpit.singh88@gmail.com" },
                    { "89", 0, null, "A+", "Azadnagar", "2311c314-982a-4359-9416-2e1559af308c", "India", "ApplicationUser", "yash.bansal89@gmail.com", true, "Yash Bansal", false, null, "YASH.BANSAL89@GMAIL.COM", "YASH.BANSAL89@GMAIL.COM", "AQAAAAIAAYagAAAAEL6gExiJc16F2kZc9OU7zdaKMnLkWJEMuB1P++gv5tQVFZhe5x+tL9mokmRtPG64wg==", null, "123-456-7890", false, null, "9f2456a5-f2dc-4e05-935a-3ea6992ae159", "U.P", false, "yash.bansal89@gmail.com" },
                    { "9", 0, null, "A+", "Krishna Nagar", "c1418963-b7d1-44b4-8e79-9de3fa337225", "India", "ApplicationUser", "monika.bansal9@gmail.com", true, "Monika Bansal", false, null, "MONIKA.BANSAL9@GMAIL.COM", "MONIKA.BANSAL9@GMAIL.COM", "AQAAAAIAAYagAAAAEJPipdB/nelwvquootexSuoKOJY7tpFr/AYqCA3eN98/wy88SDB4hqd1i6cQQ5zr/w==", null, "123-456-7890", false, null, "b6f3e73a-0734-4f2e-94f1-2c1488cbd8c2", "Chandigarh", false, "monika.bansal9@gmail.com" },
                    { "90", 0, null, "A-", "Krishna Nagar", "b5848790-3b02-4897-9914-92bfbf3893a1", "India", "ApplicationUser", "vinay.jain90@gmail.com", true, "Vinay Jain", false, null, "VINAY.JAIN90@GMAIL.COM", "VINAY.JAIN90@GMAIL.COM", "AQAAAAIAAYagAAAAEOr24tISm7Gmn0PQ+TUArt3A1I5ZXO1D97jOszlpMVfrXaamxbcbANL96+34X/Y/4A==", null, "123-456-7890", false, null, "b3ba9c57-1626-4fe6-b249-7df08d4a75ad", "Haryana", false, "vinay.jain90@gmail.com" },
                    { "91", 0, null, "B+", "Gaziabad", "a331df18-aa85-4942-8ac8-539f47ce4d48", "India", "ApplicationUser", "ritik.goyal91@gmail.com", true, "Ritik Goyal", false, null, "RITIK.GOYAL91@GMAIL.COM", "RITIK.GOYAL91@GMAIL.COM", "AQAAAAIAAYagAAAAEA9yGOEPw6LgJk1XCIMVTOMxIXLOeAHa2JOEqlSIaBUM2rHqs+mq7Y/BNwv4mGjVcQ==", null, "123-456-7890", false, null, "ecb63824-175e-43ed-bbe7-f5fab6730c90", "New Delhi", false, "ritik.goyal91@gmail.com" },
                    { "92", 0, null, "B-", "Noida", "807a9343-a733-4ef4-b4b3-7fdc07fc72c8", "India", "ApplicationUser", "jatin.sharma92@gmail.com", true, "Jatin Sharma", false, null, "JATIN.SHARMA92@GMAIL.COM", "JATIN.SHARMA92@GMAIL.COM", "AQAAAAIAAYagAAAAENpUN5X7UNCEsnTBPVhANnxbxK/VsM/H51yj4i/I3MNdG41gyy/xS+Kot67qD5O5zg==", null, "123-456-7890", false, null, "9a7d874c-d0e6-4686-9678-971d248cfbb6", "Mumbai", false, "jatin.sharma92@gmail.com" },
                    { "93", 0, null, "O+", "Faridabad", "5e1d4bf1-21ce-4fd5-8bca-df6290a0e05c", "India", "ApplicationUser", "sneha.gupta93@gmail.com", true, "Sneha Gupta", false, null, "SNEHA.GUPTA93@GMAIL.COM", "SNEHA.GUPTA93@GMAIL.COM", "AQAAAAIAAYagAAAAEIWQ9oFr6IFAUnyxSPgFjZit81P4MXq35qkQpw/Wh0uTJ6WecCKGlslhGxknWoHDVg==", null, "123-456-7890", false, null, "5ebcfb03-f2a0-4f82-ae0a-3cd30c3d97ed", "Chandigarh", false, "sneha.gupta93@gmail.com" },
                    { "94", 0, null, "O-", "Shahdara", "addbf8e1-16dd-4925-a3bd-9bdb7d651c0a", "India", "ApplicationUser", "monika.prakash94@gmail.com", true, "Monika Prakash", false, null, "MONIKA.PRAKASH94@GMAIL.COM", "MONIKA.PRAKASH94@GMAIL.COM", "AQAAAAIAAYagAAAAEMh5QJz5oTiVVlhNkPVpLiw2F4dK5q048xJjDbDy2SNBDw0gpy1foeyfBgvY+6YItw==", null, "123-456-7890", false, null, "9691292f-e976-422b-8ba0-7e05cb5b0639", "Banglore", false, "monika.prakash94@gmail.com" },
                    { "95", 0, null, "AB+", "Rohini", "60bd3971-7bd3-457a-9970-554978db5caa", "India", "ApplicationUser", "tanisha.aggarwal95@gmail.com", true, "Tanisha Aggarwal", false, null, "TANISHA.AGGARWAL95@GMAIL.COM", "TANISHA.AGGARWAL95@GMAIL.COM", "AQAAAAIAAYagAAAAEDsj9xCVGkY2uaPiiIKUQwrq+1NMQF7B5fU1j84ifw+iDRCNptF3FqrbNhJfjCBTiA==", null, "123-456-7890", false, null, "66bf3cf5-b753-4826-b97f-7a315b3f7a95", "U.P", false, "tanisha.aggarwal95@gmail.com" },
                    { "96", 0, null, "AB-", "Patel Nagar", "58c130c9-9000-4def-a4b7-c8d4fc9280fa", "India", "ApplicationUser", "manya.singh96@gmail.com", true, "Manya Singh", false, null, "MANYA.SINGH96@GMAIL.COM", "MANYA.SINGH96@GMAIL.COM", "AQAAAAIAAYagAAAAEJot+14qqE3uuy9jutfxMgpzYuVW9rRsHH3le2WuDreTiWNNjYeFjI+O2j/akU4ZmQ==", null, "123-456-7890", false, null, "22082891-5b4d-4037-8e99-0e91aee0f642", "Haryana", false, "manya.singh96@gmail.com" },
                    { "97", 0, null, "A+", "Dwarka", "ee534953-d2ac-484f-ac89-849c8b69a060", "India", "ApplicationUser", "khushi.bansal97@gmail.com", true, "Khushi Bansal", false, null, "KHUSHI.BANSAL97@GMAIL.COM", "KHUSHI.BANSAL97@GMAIL.COM", "AQAAAAIAAYagAAAAEDfpCkDjT23AGeRcVYyema0nouKZ4yTkxdQBoyvGb38uJUOWV1ovRskMn1C4pFbdkg==", null, "123-456-7890", false, null, "8ec674ad-9c47-4a50-8cd5-43a5a76deb40", "New Delhi", false, "khushi.bansal97@gmail.com" },
                    { "98", 0, null, "A-", "Azadnagar", "b32e337f-4bca-4f8d-9d4a-dcf64d46295e", "India", "ApplicationUser", "kritika.jain98@gmail.com", true, "Kritika Jain", false, null, "KRITIKA.JAIN98@GMAIL.COM", "KRITIKA.JAIN98@GMAIL.COM", "AQAAAAIAAYagAAAAEOmb6kWJ7i3uHLJT0WStpszaKJdBeO10TFFCTk+GaXNOgIJnBLnuPdnC6JhMvQVmqA==", null, "123-456-7890", false, null, "f1266004-7ef1-412b-87d5-88a8361058ef", "Mumbai", false, "kritika.jain98@gmail.com" },
                    { "99", 0, null, "B+", "Krishna Nagar", "c1ed377c-2d39-4404-b795-b94ccfed0ac7", "India", "ApplicationUser", "preeti.goyal99@gmail.com", true, "Preeti Goyal", false, null, "PREETI.GOYAL99@GMAIL.COM", "PREETI.GOYAL99@GMAIL.COM", "AQAAAAIAAYagAAAAENlhnhanSIEzQt9gt11yji6ar9ULBbR6EhVs0eTYmUxw7O1YojbUlulW0OZCJ4sKTA==", null, "123-456-7890", false, null, "400ac660-c901-4454-95b0-881024b8c932", "Chandigarh", false, "preeti.goyal99@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99");
        }
    }
}
