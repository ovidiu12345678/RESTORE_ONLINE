

import { Container, CssBaseline, ThemeProvider, createTheme } from "@mui/material";
import Atent from "./Header";
import { useState } from "react";
import { Outlet } from "react-router-dom";


function App() {
  const [modIntunecat, seteazaModIntunecat] = useState(false)
  const tipPalete = modIntunecat? 'dark' : 'light';
  const teme = createTheme({
    palette:{
      mode: tipPalete,
      background:{
        default: tipPalete === 'light' ? '#eaeaea' : '#121212'
      }
    }
  })
  function gestionareSchimbareTema(){
    seteazaModIntunecat(!modIntunecat);
  }
  return (
    <ThemeProvider theme={teme}>
    <CssBaseline />
     <Atent modIntunecat= {modIntunecat} gestionareSchimareTema={gestionareSchimbareTema}/> 
     <Container>
     <Outlet />
     
     </Container>
     
    </ThemeProvider>
  );
}

export default App;
