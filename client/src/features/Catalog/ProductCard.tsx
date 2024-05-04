import { Avatar, Button, Card, CardActions, CardContent, CardHeader, CardMedia, Typography } from "@mui/material";
import { Produse } from "../../app/models/produse";
import { Link } from "react-router-dom";


interface Props{
  produs: Produse;
}

export default function CardProduse({produs}: Props){
  return(
    <Card >
      <CardHeader
        avatar={
          <Avatar sx={{bgcolor: 'secundary.main'}}>
            {produs.nume.charAt(0).toUpperCase()}
          </Avatar>
        } 
        title={produs.nume}
       titleTypographyProps={{
        sx:{fontWeight: 'bold', color: 'primary.main'}
       }}
      />
      <CardMedia 
        sx={{ height: 140 , backgroundSize: 'contain', bgcolor: 'primary.light'}}
        image= {produs.adresaUrlImagini}
        title={produs.nume}
      />
      <CardContent>
        <Typography gutterBottom color= 'secundary' variant="h5">
          ${(produs.pret / 100).toFixed(2)}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {produs.brend} / {produs.tip}
        </Typography>
      </CardContent>
      <CardActions>
        <Button size="small">Adauga in cos</Button>
        <Button component={Link} to={`/catalog/${produs.id}`} size="small">vedeti</Button>
      </CardActions>
    </Card>
  )
}