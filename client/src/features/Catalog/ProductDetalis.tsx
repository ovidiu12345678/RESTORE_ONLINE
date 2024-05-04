import { Divider, Grid, Typography } from "@mui/material";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Produse } from "../../app/models/produse";
import axios from "axios";

export default function DetaliiProduse() {
  const { id } = useParams<{ id: string }>();

  const [produs, setProdus] = useState<Produse>();
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    async function fetchProdus() {
      try {
        const response = await axios.get(`http://localhost:5000/api/ControlerProduseAPI/${id}`);
        setProdus(response.data);
        setLoading(false);
      } catch (error) {
        console.error("Eroare API:", error);
        setError("A aparut o eroare la Incarcarea produsului.");
        setLoading(false);
      }
    }

    fetchProdus();
  }, [id]);

  if (loading) return <h3>Se Incarca...</h3>;
  if (error) return <h3>Eroare: {error}</h3>;
  if (!produs) return <h3>Nu exista produse</h3>;

  return (
    <Grid container spacing={6}>
      <Grid item xs={6}>
        {produs.adresaUrlImagini && (
          <img src={produs.adresaUrlImagini} alt={produs.nume} style={{ width: '100%' }} />
        )}
      </Grid>
      <Grid item xs={6}>
        <Typography variant="h3">{produs.nume}</Typography>
        <Divider sx={{ mb: 2 }} />
        
      </Grid>
    </Grid>
  );
}
