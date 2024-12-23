using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
	public class MemoryDataService : IDataService
	{
		private IEnumerable<TaskItem> tasks = [
			new () { Id = 1, Title = "Задача 1", Description = "Описание задачи 1", CreateTDate = DateTime.Now },
			new () { Id = 2, Title = "Задача 2", Description = "Описание задачи 2", CreateTDate = DateTime.Now },
			new () { Id = 3, Title = "Задача 3", Description = "Описание задачи 3", CreateTDate = DateTime.Now, }
		];

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<TaskItem> GetTaskAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<TaskItem>> GetAllAsync()
		{
			await Task.Delay(1000);
			return await Task.FromResult(tasks);
		}

		public Task SaveAsync(TaskItem item)
		{
			throw new NotImplementedException();
		}
	}
}