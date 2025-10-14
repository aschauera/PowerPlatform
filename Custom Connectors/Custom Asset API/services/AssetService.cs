using Custom_Asset_API;

namespace Custom_Asset_API.Services;

public static class AssetService
{
    static List<Asset> Assets { get; }
    static int nextId = 3;
    static AssetService()
    {
        Assets = new List<Asset>
        {
            new Asset { ID = 1, Name = "Compactor C1", Code = "A1001", Location = "LAC 2, Hall B", InstallDate = DateOnly.FromDateTime( DateTime.Now.AddDays(-100)) },
            new Asset { ID = 2, Name = "Waste Press XI12", Code = "MA001", Location = "LAC 1 - Hall A",InstallDate = DateOnly.FromDateTime( DateTime.Now.AddDays(-110))  },
            new Asset { ID = 3, Name = "Waste Press XI12", Code = "A1002", Location = "LAC 1 - Hall B",InstallDate = DateOnly.FromDateTime( DateTime.Now.AddDays(-150))  }
        };
    }

    public static List<Asset> GetAll() => Assets;

    public static Asset? Get(int id) => Assets.FirstOrDefault(a => a.ID == id);

    public static void Add(Asset asset)
    {
        asset.ID = nextId++;
        Assets.Add(asset);
    }

    public static void Delete(int id)
    {
        var asset = Get(id);
        if(asset is null)
            return;

        Assets.Remove(asset);
    }

    public static void Update(Asset asset)
    {
        var index = Assets.FindIndex(a => a.ID == asset.ID);
        if(index == -1)
            return;

        Assets[index] = asset;
    }
}