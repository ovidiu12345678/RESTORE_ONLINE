import { createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import Catalog from "../../features/Catalog/Catalog";
import DetaliiProduse from "../../features/Catalog/ProductDetalis";
import HomePage from "../../features/Home/HomePage";
import AboutPage from "../../features/about/AboutPage";
import ContactPage from "../../features/contact/ContactPage";


export const router = createBrowserRouter([
  {
    path: '/',
    element: <App />,
    children: [
      {path: '',  element: <HomePage />},
      {path: 'catalog', element: <Catalog />},
      {path: 'catalog/:id', element: <DetaliiProduse />},
      {path: 'about', element: <AboutPage />},
      {path: 'contact', element: < ContactPage />},
    ]
  }
])