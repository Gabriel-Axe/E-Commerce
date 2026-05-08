import { useState } from 'react';
import ProductCreate from './pages/Product';
import ProductSearch from './pages/ProductSearch';
import UserCreate from './pages/User';
import ShopCreate from './pages/Shop';
import { createRoot } from 'react-dom/client'
import { StrictMode } from 'react'
import App from '../App/App';

createRoot(document.getElementById('root')!).render(
	<StrictMode>
		<App />
	</StrictMode>,
)
