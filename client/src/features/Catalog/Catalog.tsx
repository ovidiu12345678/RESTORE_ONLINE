
import { useState, useEffect } from "react";
import axios from "axios";
import ListaProduse from "./ProductList";
import { Produse } from "../../app/models/produse";

export default function Catalog() {
  const [produse, setProduse] = useState<Produse[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    async function fetchProduse() {
      try {
        const response = await axios.get("http://localhost:5000/api/ControlerProduseAPI");
        setProduse(response.data);
        setLoading(false);
      } catch (error) {
        console.error("Eroare API:", error);
        setError("A aparut o eroare la Incarcarea produselor.");
        setLoading(false);
      }
    }

    fetchProduse();
  }, []);

  if (loading) return <h3>Se Incarca...</h3>;
  if (error) return <h3>Eroare: {error}</h3>;
  
  return (
    <>
    <ListaProduse produse={produse} />
   </>
   
  );
}
