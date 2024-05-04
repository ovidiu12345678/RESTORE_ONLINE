import { Grid} from "@mui/material";
import { Produse } from "../../app/models/produse";
import CardProduse from "./ProductCard";


interface Props{
  produse: Produse[];
}

export default function ListaProduse({produse}: Props){
  return(
    <Grid container spacing={4}>
   
    {  produse.map(produs => (
     
      <Grid item xs={3} key={produs.id}> 
         <CardProduse  produs={produs} />
      </Grid>
       
    ))}
  </Grid>
  )
}