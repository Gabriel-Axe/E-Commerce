import { createRoot } from 'react-dom/client'
import { StrictMode, useState } from 'react'
import App from './App.tsx';

const root = ReactDOM.createRoot(
	document.getElementById('root') as HTMLElement
);
root.render(
	<StrictMode>
		<App />
	</StrictMode>,
)
