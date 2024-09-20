namespace GroceryStore.DTOs
{
    public record struct ScheduleDto(int DayOfWeek,int OpenTimeHour,int OpenTimeMinute, int CloseTimeHour, int CloseTimeMinute);
}
