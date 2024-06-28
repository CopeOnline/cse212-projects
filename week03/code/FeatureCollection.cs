using System.Reflection.Metadata;

public class FeatureCollection {
    public Metadata Metadata { get; set; }
    public List<Feature> Features { get; set; }

}

public class Metadata {
    public int Count { get; set; }
}


public class Feature {
    public Properties Properties { get; set; }

}

public class Properties { 
    public string Place { get; set; }
    public decimal Mag { get; set; }
}