import { AppBar, Badge, Box, IconButton, ListItem, Switch, Toolbar, Typography } from "@mui/material";
import { ShoppingCartSharp } from "@mui/icons-material";
import { NavLink } from "react-router-dom";

const midLinks = [
  { title: 'catalog', path: '/catalog' },
  { title: 'about', path: '/about' },
  { title: 'contact', path: '/contact' }
];

const rightLinks = [
  { title: 'login', path: '/login' },
  { title: 'register', path: '/register' }
];

const navStyles = {
  color: 'inherit',
  textDecoration: 'none',
  '&:hover': {
    color: 'grey.500'
  },
  '&.active': {
    color: 'text.secondary'
  }
};

interface Props {
  modIntunecat: boolean;
  gestionareSchimareTema: () => void;
}

export default function Atent({ modIntunecat, gestionareSchimareTema }: Props) {
  return (
    <AppBar position="static" sx={{ mb: 4 }} style={{ width: '100vw' }}>
      <Toolbar sx={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
        <Box display='flex' alignItems='center'>
          <Typography variant="h6" component={NavLink} to='/' sx={navStyles}>
            RE-STORE
          </Typography>
          <Switch checked={modIntunecat} onChange={gestionareSchimareTema} />
        </Box>

        <Box sx={{ display: 'flex', alignItems: 'center' }}>
          {midLinks.map(({ title, path }) => (
            <ListItem
              component={NavLink}
              to={path}
              key={path}
              sx={navStyles}
            >
              {title.toUpperCase()}
            </ListItem>
          ))}
        </Box>

        <Box sx={{ display: 'flex', alignItems: 'center' }}>
          {rightLinks.map(({ title, path }) => (
            <ListItem
              component={NavLink}
              to={path}
              key={path}
              sx={navStyles}
            >
              {title.toUpperCase()}
            </ListItem>
          ))}
          <IconButton size="large" edge='start' color="inherit" sx={{ ml: 2 }}>
            <Badge badgeContent='4' color="secondary">
              <ShoppingCartSharp />
            </Badge>
          </IconButton>
        </Box>
      </Toolbar>
    </AppBar>
  );
}
