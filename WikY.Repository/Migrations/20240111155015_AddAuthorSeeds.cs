using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WikY.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01b43f58-f683-4e47-8905-9ee927648725"), new DateTime(2023, 12, 25, 14, 17, 28, 423, DateTimeKind.Local).AddTicks(5997), "Owen", "Quigley", new DateTime(2023, 6, 3, 0, 58, 33, 241, DateTimeKind.Local).AddTicks(9778) },
                    { new Guid("08cc35f1-6cab-49b5-a145-c0e95a10ff4d"), new DateTime(2023, 3, 28, 15, 9, 56, 158, DateTimeKind.Local).AddTicks(5524), "Andrew", "Kunde", new DateTime(2023, 6, 9, 15, 35, 4, 430, DateTimeKind.Local).AddTicks(7329) },
                    { new Guid("08e4baf6-6d60-4b19-a64d-7859b0736692"), new DateTime(2022, 9, 16, 18, 25, 38, 695, DateTimeKind.Local).AddTicks(9635), "Jose", "Douglas", new DateTime(2023, 8, 18, 5, 5, 34, 546, DateTimeKind.Local).AddTicks(8395) },
                    { new Guid("09b15b8e-40ad-4289-b500-cbad932d29a7"), new DateTime(2023, 9, 7, 5, 38, 26, 675, DateTimeKind.Local).AddTicks(9460), "Paul", "Simonis", new DateTime(2023, 10, 15, 23, 33, 58, 352, DateTimeKind.Local).AddTicks(3172) },
                    { new Guid("0f0ffaae-20f5-4800-8fb4-be6b8d418a40"), new DateTime(2022, 11, 18, 13, 27, 49, 432, DateTimeKind.Local).AddTicks(6574), "Anita", "Carroll", new DateTime(2023, 7, 17, 4, 57, 7, 892, DateTimeKind.Local).AddTicks(9973) },
                    { new Guid("1135c55c-f848-4b70-8756-d0d592a9ef51"), new DateTime(2023, 1, 29, 2, 0, 54, 533, DateTimeKind.Local).AddTicks(4216), "Penny", "Kassulke", new DateTime(2023, 7, 20, 1, 32, 55, 142, DateTimeKind.Local).AddTicks(6021) },
                    { new Guid("126aaaf7-ba25-4d15-878a-03467aa53dfe"), new DateTime(2023, 5, 27, 20, 58, 0, 207, DateTimeKind.Local).AddTicks(3202), "Fredrick", "Morar", new DateTime(2023, 11, 11, 8, 30, 37, 806, DateTimeKind.Local).AddTicks(6144) },
                    { new Guid("15516147-6d31-404c-b874-9313c5274773"), new DateTime(2023, 6, 23, 7, 8, 35, 575, DateTimeKind.Local).AddTicks(8021), "Pearl", "McCullough", new DateTime(2023, 4, 16, 1, 14, 39, 841, DateTimeKind.Local).AddTicks(8998) },
                    { new Guid("16440fb2-20d2-47bc-99a9-2d228db2ced4"), new DateTime(2023, 8, 12, 14, 27, 51, 361, DateTimeKind.Local).AddTicks(4247), "Jacquelyn", "Willms", new DateTime(2023, 6, 7, 2, 18, 14, 261, DateTimeKind.Local).AddTicks(8328) },
                    { new Guid("16f8bf3b-6cc9-412a-a59f-1a94f31b5800"), new DateTime(2022, 5, 21, 11, 45, 52, 262, DateTimeKind.Local).AddTicks(4599), "Felipe", "Conroy", new DateTime(2023, 8, 8, 17, 12, 2, 770, DateTimeKind.Local).AddTicks(7575) },
                    { new Guid("1815c5d2-eed7-4a71-8ced-8ca10e9b316c"), new DateTime(2023, 8, 9, 16, 57, 57, 433, DateTimeKind.Local).AddTicks(904), "Felicia", "Cassin", new DateTime(2023, 10, 6, 0, 16, 37, 379, DateTimeKind.Local).AddTicks(9498) },
                    { new Guid("18a1b759-a32c-47e0-8e17-cd2cc11ce695"), new DateTime(2022, 4, 1, 2, 11, 13, 497, DateTimeKind.Local).AddTicks(6511), "Harvey", "Kautzer", new DateTime(2023, 8, 11, 18, 27, 18, 800, DateTimeKind.Local).AddTicks(8079) },
                    { new Guid("195fb8e1-260f-4a04-bf18-054313cd4639"), new DateTime(2022, 12, 9, 21, 0, 23, 952, DateTimeKind.Local).AddTicks(677), "Jerry", "Zieme", new DateTime(2023, 4, 8, 0, 38, 17, 135, DateTimeKind.Local).AddTicks(6724) },
                    { new Guid("19b5bac5-5abc-4254-bc31-55e1dda0f5a2"), new DateTime(2023, 7, 29, 6, 47, 54, 396, DateTimeKind.Local).AddTicks(4088), "William", "Towne", new DateTime(2023, 2, 27, 20, 25, 11, 205, DateTimeKind.Local).AddTicks(6739) },
                    { new Guid("1a8725d1-469d-4ce2-ac99-b71137d5d75b"), new DateTime(2023, 5, 9, 21, 37, 49, 482, DateTimeKind.Local).AddTicks(4325), "Anthony", "Rutherford", new DateTime(2023, 7, 27, 3, 15, 59, 798, DateTimeKind.Local).AddTicks(9736) },
                    { new Guid("1fe3e601-293b-41fb-9b41-386c36a3caf9"), new DateTime(2023, 7, 9, 11, 15, 37, 498, DateTimeKind.Local).AddTicks(5119), "Bessie", "Predovic", new DateTime(2023, 2, 15, 23, 36, 56, 205, DateTimeKind.Local).AddTicks(5699) },
                    { new Guid("223a987c-53a7-495e-895e-7991fe86c441"), new DateTime(2022, 10, 28, 8, 18, 4, 959, DateTimeKind.Local).AddTicks(8690), "Claudia", "White", new DateTime(2023, 9, 7, 18, 13, 16, 790, DateTimeKind.Local).AddTicks(2107) },
                    { new Guid("2396a50c-f20e-4305-869b-3ddf7ef732c4"), new DateTime(2023, 7, 10, 22, 44, 24, 896, DateTimeKind.Local).AddTicks(3299), "Grant", "Predovic", new DateTime(2023, 5, 21, 17, 58, 16, 958, DateTimeKind.Local).AddTicks(6723) },
                    { new Guid("2476f5be-9841-41fb-a415-904a5363309b"), new DateTime(2023, 2, 25, 7, 39, 58, 376, DateTimeKind.Local).AddTicks(5452), "Stuart", "Morissette", new DateTime(2023, 10, 2, 15, 36, 6, 858, DateTimeKind.Local).AddTicks(9964) },
                    { new Guid("27ca287b-f80f-45ed-9aad-4b1a6c2a01f1"), new DateTime(2022, 5, 22, 9, 16, 27, 480, DateTimeKind.Local).AddTicks(9473), "Donald", "Lindgren", new DateTime(2023, 10, 23, 22, 45, 6, 217, DateTimeKind.Local).AddTicks(855) },
                    { new Guid("289577a0-e958-42c8-98c2-af95d80ebe26"), new DateTime(2023, 10, 23, 21, 18, 36, 929, DateTimeKind.Local).AddTicks(1028), "Harold", "Lehner", new DateTime(2023, 6, 6, 17, 1, 31, 994, DateTimeKind.Local).AddTicks(8375) },
                    { new Guid("29ee5253-e4ae-4a2e-8a1c-ef1fec371c01"), new DateTime(2022, 12, 9, 5, 51, 16, 96, DateTimeKind.Local).AddTicks(1694), "Javier", "Ward", new DateTime(2023, 9, 4, 16, 8, 16, 493, DateTimeKind.Local).AddTicks(6737) },
                    { new Guid("2a0fd686-3620-4a44-b790-9943b6cdbfaf"), new DateTime(2022, 7, 30, 11, 10, 27, 711, DateTimeKind.Local).AddTicks(276), "Guadalupe", "Glover", new DateTime(2023, 7, 23, 21, 43, 27, 920, DateTimeKind.Local).AddTicks(1108) },
                    { new Guid("2e246944-23d6-46f3-a8e3-5589240e5b5b"), new DateTime(2023, 2, 3, 13, 38, 25, 479, DateTimeKind.Local).AddTicks(5031), "Holly", "D'Amore", new DateTime(2023, 12, 3, 2, 42, 6, 919, DateTimeKind.Local).AddTicks(2023) },
                    { new Guid("2f7948a3-6971-4a60-a82f-bddf0f8ca842"), new DateTime(2023, 12, 2, 5, 36, 4, 141, DateTimeKind.Local).AddTicks(2950), "Victor", "Donnelly", new DateTime(2023, 6, 29, 3, 35, 34, 249, DateTimeKind.Local).AddTicks(6045) },
                    { new Guid("37fa4e96-6070-404d-99a7-fbe142ed77de"), new DateTime(2023, 12, 15, 13, 47, 5, 811, DateTimeKind.Local).AddTicks(1959), "Ruby", "Koepp", new DateTime(2023, 3, 11, 9, 40, 23, 294, DateTimeKind.Local).AddTicks(6236) },
                    { new Guid("3b69074b-1930-4798-a154-3a547371ddd6"), new DateTime(2023, 5, 22, 18, 21, 45, 751, DateTimeKind.Local).AddTicks(8313), "Stacy", "Little", new DateTime(2023, 9, 10, 12, 25, 58, 452, DateTimeKind.Local).AddTicks(5078) },
                    { new Guid("3df4c8fa-06ca-4a20-9478-f417d02da21e"), new DateTime(2023, 10, 4, 11, 8, 34, 683, DateTimeKind.Local).AddTicks(2744), "Karla", "Hartmann", new DateTime(2023, 1, 19, 5, 25, 17, 906, DateTimeKind.Local).AddTicks(7882) },
                    { new Guid("3ff436f7-17cf-4b36-a3a0-228870e784a8"), new DateTime(2023, 3, 10, 21, 38, 33, 362, DateTimeKind.Local).AddTicks(3529), "Grant", "Lockman", new DateTime(2023, 12, 8, 4, 24, 1, 381, DateTimeKind.Local).AddTicks(578) },
                    { new Guid("40d1c72f-ebc4-473d-92ad-fab04b68e383"), new DateTime(2022, 5, 25, 4, 16, 46, 604, DateTimeKind.Local).AddTicks(6788), "Deborah", "Pagac", new DateTime(2023, 5, 10, 14, 3, 4, 533, DateTimeKind.Local).AddTicks(5387) },
                    { new Guid("42a8f6d2-47a3-403b-a402-e75d89f1c161"), new DateTime(2023, 1, 22, 5, 0, 4, 433, DateTimeKind.Local).AddTicks(9107), "Brian", "Boyle", new DateTime(2023, 7, 4, 11, 55, 11, 797, DateTimeKind.Local).AddTicks(9740) },
                    { new Guid("437ea32d-e583-4067-a7e7-b9a2a9d3e8c3"), new DateTime(2022, 7, 11, 6, 37, 50, 203, DateTimeKind.Local).AddTicks(9786), "Frankie", "Anderson", new DateTime(2023, 1, 15, 13, 35, 16, 275, DateTimeKind.Local).AddTicks(8834) },
                    { new Guid("498b62c3-708a-42be-9fdb-bd2f2561bf70"), new DateTime(2022, 2, 23, 9, 30, 0, 98, DateTimeKind.Local).AddTicks(627), "Curtis", "Carter", new DateTime(2023, 7, 11, 4, 19, 58, 488, DateTimeKind.Local).AddTicks(8543) },
                    { new Guid("4fb279e1-88e6-4196-b462-8c380383cb01"), new DateTime(2022, 12, 24, 21, 36, 50, 743, DateTimeKind.Local).AddTicks(6978), "Erma", "Stokes", new DateTime(2023, 1, 11, 21, 27, 14, 490, DateTimeKind.Local).AddTicks(6698) },
                    { new Guid("51b13165-d3ff-4e99-b55a-8e6fb00a3771"), new DateTime(2022, 3, 8, 7, 0, 18, 51, DateTimeKind.Local).AddTicks(9438), "Danny", "Ortiz", new DateTime(2024, 1, 9, 8, 18, 8, 673, DateTimeKind.Local).AddTicks(8640) },
                    { new Guid("54dd698c-4434-40f8-b8fd-369b5ccc1a37"), new DateTime(2023, 2, 8, 3, 10, 28, 325, DateTimeKind.Local).AddTicks(5343), "Margarita", "Romaguera", new DateTime(2023, 10, 17, 8, 2, 37, 822, DateTimeKind.Local).AddTicks(8237) },
                    { new Guid("5fd96cf0-eb5b-4e38-bd31-e5e0b9850e9a"), new DateTime(2023, 11, 6, 22, 22, 6, 229, DateTimeKind.Local).AddTicks(8706), "Robin", "Mertz", new DateTime(2023, 3, 2, 11, 33, 26, 117, DateTimeKind.Local).AddTicks(4121) },
                    { new Guid("609fa4f6-fa8a-4fca-b35c-b15145bccdad"), new DateTime(2023, 10, 26, 6, 34, 26, 974, DateTimeKind.Local).AddTicks(2286), "Luke", "Hand", new DateTime(2023, 2, 27, 13, 26, 41, 661, DateTimeKind.Local).AddTicks(9253) },
                    { new Guid("61e886d2-795f-4c83-a2fa-61ed97e606ff"), new DateTime(2023, 5, 25, 2, 21, 42, 533, DateTimeKind.Local).AddTicks(6700), "Sonya", "Legros", new DateTime(2023, 9, 13, 7, 2, 26, 243, DateTimeKind.Local).AddTicks(6459) },
                    { new Guid("625f1b54-16d5-4883-a1a3-3be31538c832"), new DateTime(2023, 3, 21, 11, 53, 2, 545, DateTimeKind.Local).AddTicks(9945), "Vera", "Lemke", new DateTime(2023, 9, 14, 6, 28, 30, 433, DateTimeKind.Local).AddTicks(6130) },
                    { new Guid("63f41afe-d052-4af2-89c9-7569d061a270"), new DateTime(2023, 8, 9, 7, 39, 22, 488, DateTimeKind.Local).AddTicks(9913), "Dale", "Smitham", new DateTime(2023, 6, 12, 6, 2, 33, 315, DateTimeKind.Local).AddTicks(8132) },
                    { new Guid("67ee8af5-217b-448f-b4dc-2bb5db366cfd"), new DateTime(2022, 11, 24, 0, 10, 49, 565, DateTimeKind.Local).AddTicks(2926), "Earnest", "Lang", new DateTime(2023, 8, 24, 13, 40, 57, 794, DateTimeKind.Local).AddTicks(7433) },
                    { new Guid("694d120f-f467-47ed-91a2-24085f8e00ae"), new DateTime(2022, 2, 25, 18, 19, 18, 263, DateTimeKind.Local).AddTicks(552), "Alice", "Dickinson", new DateTime(2023, 8, 1, 22, 38, 9, 992, DateTimeKind.Local).AddTicks(6711) },
                    { new Guid("69acc9ef-126d-45e1-b670-22a63f7e506d"), new DateTime(2023, 6, 20, 17, 43, 37, 67, DateTimeKind.Local).AddTicks(1527), "Andrea", "Heaney", new DateTime(2023, 7, 7, 19, 59, 4, 217, DateTimeKind.Local).AddTicks(9507) },
                    { new Guid("6ae66215-5a50-4639-82af-09b26d7a0573"), new DateTime(2023, 10, 21, 22, 59, 55, 904, DateTimeKind.Local).AddTicks(4378), "Marco", "Schumm", new DateTime(2023, 6, 5, 6, 6, 11, 0, DateTimeKind.Local).AddTicks(953) },
                    { new Guid("6b0f2df9-e42f-4edc-a154-d9fd9452d5db"), new DateTime(2023, 4, 12, 20, 49, 55, 865, DateTimeKind.Local).AddTicks(1384), "Ronnie", "Crist", new DateTime(2023, 1, 31, 8, 2, 50, 418, DateTimeKind.Local).AddTicks(5840) },
                    { new Guid("6f306e43-5df2-4321-826c-2fd45b26f5fe"), new DateTime(2023, 6, 17, 23, 27, 48, 306, DateTimeKind.Local).AddTicks(336), "Lamar", "Simonis", new DateTime(2023, 3, 5, 19, 52, 53, 32, DateTimeKind.Local).AddTicks(2355) },
                    { new Guid("7171d2eb-41db-4e3e-a755-473586fe654e"), new DateTime(2023, 9, 27, 17, 9, 45, 380, DateTimeKind.Local).AddTicks(2712), "Catherine", "Feest", new DateTime(2023, 8, 8, 1, 53, 37, 831, DateTimeKind.Local).AddTicks(4753) },
                    { new Guid("723a202c-29e7-456b-a946-50f86c671b41"), new DateTime(2022, 3, 18, 20, 48, 46, 150, DateTimeKind.Local).AddTicks(3487), "Boyd", "Cormier", new DateTime(2023, 10, 18, 13, 34, 17, 827, DateTimeKind.Local).AddTicks(5237) },
                    { new Guid("72a040b2-863f-49ef-bffc-2840e6eb81d3"), new DateTime(2022, 3, 4, 2, 9, 9, 727, DateTimeKind.Local).AddTicks(268), "Jack", "Sauer", new DateTime(2023, 3, 8, 7, 40, 7, 748, DateTimeKind.Local).AddTicks(1387) },
                    { new Guid("72cd3996-4f7b-4f18-9304-afe946e96149"), new DateTime(2023, 4, 24, 11, 33, 16, 402, DateTimeKind.Local).AddTicks(9634), "Mattie", "Douglas", new DateTime(2023, 2, 24, 16, 30, 22, 893, DateTimeKind.Local).AddTicks(4471) },
                    { new Guid("738d10b0-449d-469e-8f3e-184765e44c18"), new DateTime(2022, 5, 20, 2, 3, 25, 507, DateTimeKind.Local).AddTicks(1635), "Constance", "Gusikowski", new DateTime(2023, 3, 19, 8, 34, 38, 969, DateTimeKind.Local).AddTicks(4675) },
                    { new Guid("7cf601c2-abe3-4a75-8671-b15255a06cd5"), new DateTime(2022, 1, 13, 14, 59, 8, 857, DateTimeKind.Local).AddTicks(2252), "Elbert", "Legros", new DateTime(2023, 9, 6, 6, 27, 59, 530, DateTimeKind.Local).AddTicks(5415) },
                    { new Guid("7f725ae7-2f64-44b7-b817-ca9fa653c69b"), new DateTime(2023, 9, 10, 15, 30, 11, 479, DateTimeKind.Local).AddTicks(3491), "Jeffery", "Metz", new DateTime(2023, 4, 4, 8, 51, 47, 52, DateTimeKind.Local).AddTicks(4291) },
                    { new Guid("8383e3eb-b994-404c-83e2-4f6ef9cdbd59"), new DateTime(2022, 12, 29, 2, 25, 33, 607, DateTimeKind.Local).AddTicks(5738), "Molly", "Roberts", new DateTime(2023, 7, 9, 5, 38, 14, 204, DateTimeKind.Local).AddTicks(4735) },
                    { new Guid("8672f219-2594-4c8a-ad5c-3de175843dcb"), new DateTime(2023, 6, 13, 8, 14, 44, 682, DateTimeKind.Local).AddTicks(656), "Ronnie", "Johnston", new DateTime(2023, 6, 9, 12, 24, 30, 820, DateTimeKind.Local).AddTicks(3662) },
                    { new Guid("87077c62-6140-49e2-9efe-82d61926f45c"), new DateTime(2022, 6, 10, 1, 41, 5, 731, DateTimeKind.Local).AddTicks(2560), "Faye", "Gleason", new DateTime(2023, 10, 2, 0, 47, 50, 57, DateTimeKind.Local).AddTicks(7145) },
                    { new Guid("8cc773e8-609c-4373-803b-86f58d42a8c4"), new DateTime(2024, 1, 6, 1, 14, 14, 513, DateTimeKind.Local).AddTicks(1905), "Carole", "Lind", new DateTime(2023, 10, 15, 0, 23, 59, 421, DateTimeKind.Local).AddTicks(116) },
                    { new Guid("8ccae548-4fc0-41d1-a309-3c6b7c09a0ee"), new DateTime(2023, 8, 25, 10, 22, 45, 505, DateTimeKind.Local).AddTicks(7891), "Hazel", "Daugherty", new DateTime(2023, 7, 15, 8, 19, 38, 893, DateTimeKind.Local).AddTicks(6418) },
                    { new Guid("8d88a220-0332-4910-b832-8a4488c30b60"), new DateTime(2022, 3, 9, 1, 24, 6, 943, DateTimeKind.Local).AddTicks(8569), "Wilfred", "Wiegand", new DateTime(2023, 10, 13, 19, 5, 25, 781, DateTimeKind.Local).AddTicks(3263) },
                    { new Guid("90ee3462-938a-464f-932c-9e00a0be2da8"), new DateTime(2022, 2, 2, 6, 50, 50, 5, DateTimeKind.Local).AddTicks(1023), "Ronald", "Goyette", new DateTime(2023, 6, 30, 16, 42, 24, 556, DateTimeKind.Local).AddTicks(3927) },
                    { new Guid("92676145-ace9-4d83-983c-b940ccf016b5"), new DateTime(2023, 8, 27, 8, 46, 30, 498, DateTimeKind.Local).AddTicks(5760), "Clara", "Hessel", new DateTime(2023, 4, 9, 4, 11, 1, 242, DateTimeKind.Local).AddTicks(9608) },
                    { new Guid("9384fc04-4875-4495-86a7-ad1bb95379f1"), new DateTime(2023, 1, 27, 11, 26, 34, 614, DateTimeKind.Local).AddTicks(4644), "Gail", "Kerluke", new DateTime(2023, 12, 26, 7, 45, 44, 818, DateTimeKind.Local).AddTicks(4317) },
                    { new Guid("941116c3-6d7e-4010-a565-f893afc7aa35"), new DateTime(2023, 8, 7, 14, 5, 41, 179, DateTimeKind.Local).AddTicks(1308), "Jackie", "Koss", new DateTime(2023, 7, 17, 20, 15, 55, 866, DateTimeKind.Local).AddTicks(1824) },
                    { new Guid("9423ffa8-02a6-435b-adbb-8ca03f0e1572"), new DateTime(2023, 12, 25, 0, 12, 7, 959, DateTimeKind.Local).AddTicks(5957), "Colin", "Johns", new DateTime(2023, 3, 5, 5, 12, 30, 260, DateTimeKind.Local).AddTicks(1500) },
                    { new Guid("9564ae55-7bfb-4542-8c3c-ef43f1c78bee"), new DateTime(2024, 1, 2, 22, 43, 35, 413, DateTimeKind.Local).AddTicks(1096), "Christopher", "Jacobs", new DateTime(2023, 4, 29, 13, 56, 38, 41, DateTimeKind.Local).AddTicks(9965) },
                    { new Guid("977ffc6b-aa8e-4048-81a6-6814fe2db5ec"), new DateTime(2022, 2, 12, 23, 12, 15, 186, DateTimeKind.Local).AddTicks(331), "Stewart", "Tromp", new DateTime(2023, 4, 1, 14, 19, 22, 340, DateTimeKind.Local).AddTicks(7477) },
                    { new Guid("9a7df460-f7b0-4722-a7ab-8c0ec126d722"), new DateTime(2022, 3, 24, 1, 16, 14, 961, DateTimeKind.Local).AddTicks(2763), "Douglas", "Boehm", new DateTime(2023, 9, 4, 9, 0, 35, 688, DateTimeKind.Local).AddTicks(4498) },
                    { new Guid("9aca7ddd-f741-441d-ae82-7d106785459a"), new DateTime(2023, 2, 22, 6, 15, 5, 125, DateTimeKind.Local).AddTicks(7538), "Rufus", "Kub", new DateTime(2024, 1, 9, 6, 10, 7, 327, DateTimeKind.Local).AddTicks(4098) },
                    { new Guid("9b6c2c79-08f5-4bd7-aaf7-bb2df85d231b"), new DateTime(2023, 9, 12, 15, 8, 19, 857, DateTimeKind.Local).AddTicks(2202), "Hubert", "Romaguera", new DateTime(2023, 12, 1, 22, 18, 57, 220, DateTimeKind.Local).AddTicks(8404) },
                    { new Guid("9ca934dc-b593-48e3-8935-111f3c3f4682"), new DateTime(2023, 6, 19, 18, 59, 59, 155, DateTimeKind.Local).AddTicks(934), "Lowell", "Huels", new DateTime(2023, 2, 26, 23, 19, 49, 33, DateTimeKind.Local).AddTicks(4011) },
                    { new Guid("a2e9fb4f-1b47-475c-8909-e8fb232c4d6a"), new DateTime(2023, 10, 19, 23, 50, 19, 567, DateTimeKind.Local).AddTicks(5823), "Gilbert", "Block", new DateTime(2023, 9, 2, 5, 55, 54, 123, DateTimeKind.Local).AddTicks(8261) },
                    { new Guid("a3d18a94-11c1-4078-9555-39e257aedff8"), new DateTime(2022, 10, 7, 1, 45, 48, 976, DateTimeKind.Local).AddTicks(4995), "Sue", "Herman", new DateTime(2023, 3, 17, 8, 33, 44, 20, DateTimeKind.Local).AddTicks(7580) },
                    { new Guid("a4c8c15f-6c6b-405f-8251-ce4719ed7dc7"), new DateTime(2023, 8, 8, 16, 15, 42, 289, DateTimeKind.Local).AddTicks(9284), "Erin", "Crooks", new DateTime(2023, 1, 14, 12, 44, 27, 101, DateTimeKind.Local).AddTicks(1929) },
                    { new Guid("a5fbd8ab-960f-468a-96b0-1477482bfd65"), new DateTime(2022, 10, 31, 13, 45, 16, 797, DateTimeKind.Local).AddTicks(7680), "Carmen", "Schinner", new DateTime(2023, 10, 31, 22, 15, 53, 889, DateTimeKind.Local).AddTicks(2511) },
                    { new Guid("a73c4969-09c4-4f8c-b254-ceb2f69ad694"), new DateTime(2022, 10, 11, 23, 20, 51, 146, DateTimeKind.Local).AddTicks(527), "Lonnie", "Rodriguez", new DateTime(2023, 4, 4, 1, 20, 27, 83, DateTimeKind.Local).AddTicks(9363) },
                    { new Guid("acbe9716-13b1-4731-b732-85c9ba259583"), new DateTime(2022, 12, 27, 14, 42, 56, 148, DateTimeKind.Local).AddTicks(5187), "Ray", "Funk", new DateTime(2023, 5, 21, 23, 23, 49, 194, DateTimeKind.Local).AddTicks(6615) },
                    { new Guid("b3cda31e-4368-4ac8-9fbc-92955ab76c4a"), new DateTime(2023, 1, 26, 0, 34, 17, 98, DateTimeKind.Local).AddTicks(7638), "Tracey", "Becker", new DateTime(2023, 9, 30, 3, 54, 54, 174, DateTimeKind.Local).AddTicks(5354) },
                    { new Guid("b8d9f710-97fc-4f2d-aa92-21ecc64efb8a"), new DateTime(2022, 9, 15, 21, 48, 8, 924, DateTimeKind.Local).AddTicks(2396), "Rex", "Lakin", new DateTime(2023, 11, 1, 8, 23, 34, 339, DateTimeKind.Local).AddTicks(6072) },
                    { new Guid("b918391f-0751-4a2c-b8c0-5c861cab3690"), new DateTime(2023, 6, 12, 11, 59, 18, 842, DateTimeKind.Local).AddTicks(4008), "Spencer", "Corkery", new DateTime(2023, 10, 23, 9, 35, 10, 982, DateTimeKind.Local).AddTicks(2929) },
                    { new Guid("bec8efbc-ec9a-415c-ab2a-7136fb4d6208"), new DateTime(2023, 11, 16, 3, 34, 44, 286, DateTimeKind.Local).AddTicks(7736), "Lula", "Metz", new DateTime(2023, 2, 8, 3, 39, 34, 648, DateTimeKind.Local).AddTicks(9313) },
                    { new Guid("c2ae4523-487b-4f26-9df9-cd717f12eb37"), new DateTime(2022, 4, 19, 18, 15, 22, 231, DateTimeKind.Local).AddTicks(4070), "Zachary", "Halvorson", new DateTime(2023, 4, 22, 1, 59, 2, 673, DateTimeKind.Local).AddTicks(4533) },
                    { new Guid("cce9f84b-1efd-4577-83e8-a56f05d3e310"), new DateTime(2022, 2, 9, 3, 30, 32, 549, DateTimeKind.Local).AddTicks(8195), "Gloria", "Thiel", new DateTime(2023, 9, 14, 2, 13, 5, 493, DateTimeKind.Local).AddTicks(6713) },
                    { new Guid("ce0f40a8-db42-45c1-8fd0-433e6e72eb26"), new DateTime(2022, 6, 17, 1, 36, 52, 82, DateTimeKind.Local).AddTicks(377), "Wanda", "Shanahan", new DateTime(2023, 7, 16, 14, 10, 34, 17, DateTimeKind.Local).AddTicks(9382) },
                    { new Guid("d3475756-04b2-47bb-bad1-61d236405f7e"), new DateTime(2024, 1, 10, 13, 2, 44, 836, DateTimeKind.Local).AddTicks(930), "Stacy", "Grimes", new DateTime(2023, 11, 8, 23, 22, 24, 640, DateTimeKind.Local).AddTicks(2367) },
                    { new Guid("de3a90b7-8b44-42b1-8d5d-2df2b032770d"), new DateTime(2023, 2, 20, 10, 14, 14, 509, DateTimeKind.Local).AddTicks(8033), "Spencer", "Langworth", new DateTime(2023, 12, 16, 20, 34, 7, 962, DateTimeKind.Local).AddTicks(8665) },
                    { new Guid("dec93779-7efd-4a50-b308-b57f21346036"), new DateTime(2022, 7, 29, 23, 7, 11, 549, DateTimeKind.Local).AddTicks(7584), "Tom", "Lowe", new DateTime(2023, 5, 23, 2, 38, 41, 663, DateTimeKind.Local).AddTicks(6711) },
                    { new Guid("e6014f57-52dd-45c7-b28e-f3a16c08421a"), new DateTime(2022, 11, 27, 14, 48, 48, 950, DateTimeKind.Local).AddTicks(2118), "Irvin", "Boyle", new DateTime(2023, 3, 2, 5, 22, 43, 939, DateTimeKind.Local).AddTicks(4671) },
                    { new Guid("e71b3daa-8369-4564-97fe-0166d9a41d9f"), new DateTime(2022, 11, 22, 21, 49, 21, 534, DateTimeKind.Local).AddTicks(7703), "Claire", "Goodwin", new DateTime(2023, 12, 25, 5, 5, 49, 956, DateTimeKind.Local).AddTicks(1478) },
                    { new Guid("ec137eb9-4669-442c-af24-f40e8f316e48"), new DateTime(2022, 5, 19, 5, 7, 52, 277, DateTimeKind.Local).AddTicks(3391), "Maria", "Balistreri", new DateTime(2023, 2, 13, 11, 33, 12, 508, DateTimeKind.Local).AddTicks(94) },
                    { new Guid("ecabcfa7-375c-4680-a88f-b9b49df9bed7"), new DateTime(2023, 2, 24, 19, 32, 51, 756, DateTimeKind.Local).AddTicks(5795), "Audrey", "Moore", new DateTime(2023, 11, 11, 13, 1, 35, 350, DateTimeKind.Local).AddTicks(6859) },
                    { new Guid("edeecb9b-3b57-4b21-af90-ef25a5b3813e"), new DateTime(2022, 3, 4, 8, 31, 1, 576, DateTimeKind.Local).AddTicks(9596), "Ross", "Emard", new DateTime(2023, 3, 24, 18, 3, 41, 328, DateTimeKind.Local).AddTicks(9066) },
                    { new Guid("ef30fb6d-b866-41b8-b1fa-bc1d7daf804a"), new DateTime(2023, 4, 1, 13, 35, 3, 61, DateTimeKind.Local).AddTicks(875), "Linda", "Beatty", new DateTime(2023, 6, 26, 7, 15, 50, 642, DateTimeKind.Local).AddTicks(3577) },
                    { new Guid("f1e7a4b5-2c11-40da-97f9-161bb131cc2b"), new DateTime(2022, 7, 30, 5, 52, 50, 967, DateTimeKind.Local).AddTicks(4515), "Blanca", "Adams", new DateTime(2023, 3, 25, 19, 49, 53, 443, DateTimeKind.Local).AddTicks(358) },
                    { new Guid("f3197d84-df7b-43eb-bd08-37d58df362f8"), new DateTime(2023, 3, 23, 16, 0, 17, 388, DateTimeKind.Local).AddTicks(936), "Heather", "Schuster", new DateTime(2023, 2, 9, 18, 22, 59, 502, DateTimeKind.Local).AddTicks(9668) },
                    { new Guid("f35a5e71-1305-4a52-a132-725b28fe5222"), new DateTime(2022, 7, 23, 15, 39, 49, 186, DateTimeKind.Local).AddTicks(4725), "Luther", "Farrell", new DateTime(2023, 8, 4, 14, 12, 17, 951, DateTimeKind.Local).AddTicks(9389) },
                    { new Guid("f6477d5b-7260-46a5-bb63-5b2554fffdd8"), new DateTime(2022, 7, 24, 1, 6, 59, 527, DateTimeKind.Local).AddTicks(5250), "Josefina", "Feeney", new DateTime(2023, 8, 15, 20, 26, 21, 800, DateTimeKind.Local).AddTicks(5283) },
                    { new Guid("f8ef648b-07f5-4b08-8db9-e42324fee902"), new DateTime(2023, 11, 11, 6, 42, 5, 188, DateTimeKind.Local).AddTicks(3582), "Bob", "Cummings", new DateTime(2023, 10, 10, 7, 6, 29, 727, DateTimeKind.Local).AddTicks(9606) },
                    { new Guid("fe1f0905-9f8f-4f5a-8cb1-92261850bb42"), new DateTime(2023, 5, 5, 9, 26, 55, 848, DateTimeKind.Local).AddTicks(2677), "Alejandro", "Bins", new DateTime(2023, 9, 13, 6, 16, 26, 973, DateTimeKind.Local).AddTicks(8227) },
                    { new Guid("ffa01b3d-6217-48dc-b1fd-664ea2a9a267"), new DateTime(2023, 3, 5, 19, 22, 12, 752, DateTimeKind.Local).AddTicks(3455), "Nathaniel", "Wolff", new DateTime(2023, 4, 22, 0, 22, 20, 850, DateTimeKind.Local).AddTicks(908) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("01b43f58-f683-4e47-8905-9ee927648725"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("08cc35f1-6cab-49b5-a145-c0e95a10ff4d"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("08e4baf6-6d60-4b19-a64d-7859b0736692"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("09b15b8e-40ad-4289-b500-cbad932d29a7"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("0f0ffaae-20f5-4800-8fb4-be6b8d418a40"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("1135c55c-f848-4b70-8756-d0d592a9ef51"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("126aaaf7-ba25-4d15-878a-03467aa53dfe"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("15516147-6d31-404c-b874-9313c5274773"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("16440fb2-20d2-47bc-99a9-2d228db2ced4"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("16f8bf3b-6cc9-412a-a59f-1a94f31b5800"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("1815c5d2-eed7-4a71-8ced-8ca10e9b316c"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("18a1b759-a32c-47e0-8e17-cd2cc11ce695"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("195fb8e1-260f-4a04-bf18-054313cd4639"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("19b5bac5-5abc-4254-bc31-55e1dda0f5a2"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("1a8725d1-469d-4ce2-ac99-b71137d5d75b"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("1fe3e601-293b-41fb-9b41-386c36a3caf9"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("223a987c-53a7-495e-895e-7991fe86c441"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("2396a50c-f20e-4305-869b-3ddf7ef732c4"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("2476f5be-9841-41fb-a415-904a5363309b"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("27ca287b-f80f-45ed-9aad-4b1a6c2a01f1"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("289577a0-e958-42c8-98c2-af95d80ebe26"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("29ee5253-e4ae-4a2e-8a1c-ef1fec371c01"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("2a0fd686-3620-4a44-b790-9943b6cdbfaf"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("2e246944-23d6-46f3-a8e3-5589240e5b5b"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("2f7948a3-6971-4a60-a82f-bddf0f8ca842"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("37fa4e96-6070-404d-99a7-fbe142ed77de"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("3b69074b-1930-4798-a154-3a547371ddd6"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("3df4c8fa-06ca-4a20-9478-f417d02da21e"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("3ff436f7-17cf-4b36-a3a0-228870e784a8"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("40d1c72f-ebc4-473d-92ad-fab04b68e383"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("42a8f6d2-47a3-403b-a402-e75d89f1c161"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("437ea32d-e583-4067-a7e7-b9a2a9d3e8c3"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("498b62c3-708a-42be-9fdb-bd2f2561bf70"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("4fb279e1-88e6-4196-b462-8c380383cb01"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("51b13165-d3ff-4e99-b55a-8e6fb00a3771"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("54dd698c-4434-40f8-b8fd-369b5ccc1a37"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("5fd96cf0-eb5b-4e38-bd31-e5e0b9850e9a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("609fa4f6-fa8a-4fca-b35c-b15145bccdad"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("61e886d2-795f-4c83-a2fa-61ed97e606ff"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("625f1b54-16d5-4883-a1a3-3be31538c832"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("63f41afe-d052-4af2-89c9-7569d061a270"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("67ee8af5-217b-448f-b4dc-2bb5db366cfd"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("694d120f-f467-47ed-91a2-24085f8e00ae"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("69acc9ef-126d-45e1-b670-22a63f7e506d"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("6ae66215-5a50-4639-82af-09b26d7a0573"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("6b0f2df9-e42f-4edc-a154-d9fd9452d5db"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("6f306e43-5df2-4321-826c-2fd45b26f5fe"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("7171d2eb-41db-4e3e-a755-473586fe654e"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("723a202c-29e7-456b-a946-50f86c671b41"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("72a040b2-863f-49ef-bffc-2840e6eb81d3"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("72cd3996-4f7b-4f18-9304-afe946e96149"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("738d10b0-449d-469e-8f3e-184765e44c18"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("7cf601c2-abe3-4a75-8671-b15255a06cd5"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("7f725ae7-2f64-44b7-b817-ca9fa653c69b"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("8383e3eb-b994-404c-83e2-4f6ef9cdbd59"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("8672f219-2594-4c8a-ad5c-3de175843dcb"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("87077c62-6140-49e2-9efe-82d61926f45c"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("8cc773e8-609c-4373-803b-86f58d42a8c4"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("8ccae548-4fc0-41d1-a309-3c6b7c09a0ee"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("8d88a220-0332-4910-b832-8a4488c30b60"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("90ee3462-938a-464f-932c-9e00a0be2da8"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("92676145-ace9-4d83-983c-b940ccf016b5"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("9384fc04-4875-4495-86a7-ad1bb95379f1"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("941116c3-6d7e-4010-a565-f893afc7aa35"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("9423ffa8-02a6-435b-adbb-8ca03f0e1572"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("9564ae55-7bfb-4542-8c3c-ef43f1c78bee"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("977ffc6b-aa8e-4048-81a6-6814fe2db5ec"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("9a7df460-f7b0-4722-a7ab-8c0ec126d722"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("9aca7ddd-f741-441d-ae82-7d106785459a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("9b6c2c79-08f5-4bd7-aaf7-bb2df85d231b"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("9ca934dc-b593-48e3-8935-111f3c3f4682"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("a2e9fb4f-1b47-475c-8909-e8fb232c4d6a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("a3d18a94-11c1-4078-9555-39e257aedff8"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("a4c8c15f-6c6b-405f-8251-ce4719ed7dc7"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("a5fbd8ab-960f-468a-96b0-1477482bfd65"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("a73c4969-09c4-4f8c-b254-ceb2f69ad694"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("acbe9716-13b1-4731-b732-85c9ba259583"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("b3cda31e-4368-4ac8-9fbc-92955ab76c4a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("b8d9f710-97fc-4f2d-aa92-21ecc64efb8a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("b918391f-0751-4a2c-b8c0-5c861cab3690"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("bec8efbc-ec9a-415c-ab2a-7136fb4d6208"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("c2ae4523-487b-4f26-9df9-cd717f12eb37"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("cce9f84b-1efd-4577-83e8-a56f05d3e310"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("ce0f40a8-db42-45c1-8fd0-433e6e72eb26"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("d3475756-04b2-47bb-bad1-61d236405f7e"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("de3a90b7-8b44-42b1-8d5d-2df2b032770d"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("dec93779-7efd-4a50-b308-b57f21346036"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("e6014f57-52dd-45c7-b28e-f3a16c08421a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("e71b3daa-8369-4564-97fe-0166d9a41d9f"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("ec137eb9-4669-442c-af24-f40e8f316e48"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("ecabcfa7-375c-4680-a88f-b9b49df9bed7"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("edeecb9b-3b57-4b21-af90-ef25a5b3813e"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("ef30fb6d-b866-41b8-b1fa-bc1d7daf804a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("f1e7a4b5-2c11-40da-97f9-161bb131cc2b"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("f3197d84-df7b-43eb-bd08-37d58df362f8"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("f35a5e71-1305-4a52-a132-725b28fe5222"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("f6477d5b-7260-46a5-bb63-5b2554fffdd8"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("f8ef648b-07f5-4b08-8db9-e42324fee902"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("fe1f0905-9f8f-4f5a-8cb1-92261850bb42"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("ffa01b3d-6217-48dc-b1fd-664ea2a9a267"));
        }
    }
}
