import { Footer } from '../../widgets/footer'
import { Header } from '../../widgets/header'
import { Outlet, ScrollRestoration } from 'react-router-dom'

export const Layout = () => {
    return (
        <div style={{minHeight: '100vh', display: 'flex', flexDirection: 'column'}}>
            <ScrollRestoration />
            <Header />
            <main style={{flex: '1'}}>
                <Outlet />
            </main>
            <Footer />
        </div>
    )
}