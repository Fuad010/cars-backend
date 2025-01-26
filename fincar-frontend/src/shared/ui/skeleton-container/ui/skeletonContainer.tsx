import { FC, useState, useEffect } from 'react';
import { CardSkeleton } from 'shared/ui/card-skeleton'
import styles from './skeletonContainer.module.css'

interface SkeletonContainerProps{
    defaultCount:number
}

export const SkeletonContainer: FC<SkeletonContainerProps> = ({defaultCount}) => {
    const [count, setCount] = useState(defaultCount);

    useEffect(() => {
        const updateCountBasedOnWidth = () => {
            const width = window.innerWidth;

            if (width <= 576) {
                setCount(1);
            } else if (width <= 992) {
                setCount(2);
            } else if (width <= 1128) {
                setCount(3);
            } else {
                setCount(defaultCount);
            }
        };

        updateCountBasedOnWidth();

        window.addEventListener('resize', updateCountBasedOnWidth);

        return () => {
            window.removeEventListener('resize', updateCountBasedOnWidth);
        };
    }, [defaultCount]);

    return (
        <div className={styles.wrapper}>
            {Array.from({ length: count }).map((_, index) => (
                <CardSkeleton key={index} />
            ))}
        </div>
    ) 
}