import React, { useState, useEffect } from "react";
import { Grid, Typography, Divider, CircularProgress } from "@mui/material";
import { useParams } from "react-router-dom";
import axios from "axios";
import { Produse } from "../../app/models/produse";

export default function DetaliiProduse() {
  const { id } = useParams<{ id: string }>();

  const [produs, setProdus] = useState<Produse | null>(null);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        if (!id) {
          throw new Error("ID invalid.");
        }
        const response = await axios.get(`http://localhost:5000/api/ControlerProduseAPI/${id}`);
        setProdus(response.data);
        setLoading(false);
      } catch (error) {
        console.error("Eroare API:", error);
        setError("A aparut o eroare la incărcarea produsului.");
        setLoading(false);
      }
    };

    fetchData();
  }, [id]);

  if (!id) return <h3>ID invalid.</h3>;
  if (loading) return <CircularProgress />;
  if (error) return <h3>Eroare: {error}</h3>;
  if (!produs) return <h3>Produsul nu exista</h3>;

  
  return (
    <Grid container spacing={6} style={{ width: '100%', height: '100vh', padding: '20px' }}>
      <Grid item xs={6}>
        {produs.adresaUrlImagini && (
          <img src={produs.adresaUrlImagini} alt={produs.nume} style={{ width: '100%', height: '100%' }} />
        )}
      </Grid>
      <Grid item xs={6} style={{ display: 'flex', flexDirection: 'column', justifyContent: 'center' }}>
        <Typography variant="h3">{produs.nume}</Typography>
        <Divider sx={{ mb: 2 }} />
        <Typography>{produs.descriere}</Typography>
        <Typography>Pret: ${(produs.pret / 100).toFixed(2)}</Typography> 
        <Typography>Tip: {produs.tip}</Typography>
        <Typography>Brend: {produs.brend}</Typography>
        {produs.cantitateStoc && (
          <Typography>Cantitate in stoc: {produs.cantitateStoc}</Typography>
        )}
      </Grid>
    </Grid>
  );
}
