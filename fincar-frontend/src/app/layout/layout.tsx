import React from 'react'
import { Footer } from '../../widgets/footer'
import { Header } from '../../widgets/header'
import { Outlet, ScrollRestoration } from 'react-router-dom'

export const Layout = () => {
    return (
        <div>
            <ScrollRestoration />
            <Header />
            <main>
                <Outlet />
            </main>
            <Footer />
        </div>
    )
}